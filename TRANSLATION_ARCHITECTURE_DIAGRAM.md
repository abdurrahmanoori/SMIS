# Translation System Architecture Diagram

## Database Schema

```
┌─────────────────────┐
│      Shop           │
├─────────────────────┤
│ PublicId (PK)       │
│ Id                  │
│ Name ◄──────────┐   │  No FK!
│ ShopType        │   │  Relationship
│ Address         │   │  based on
│ PhoneNumber     │   │  value match
│ Email           │   │
│ TaxNumber       │   │
│ IsActive        │   │
└─────────────────────┘   │
                          │
                          │ Match by value
                          │
┌─────────────────────┐   │
│  TranslationKey     │   │
├─────────────────────┤   │
│ PublicId (PK)       │   │
│ Id                  │   │
│ Name ◄──────────────┘
│ MessageCode         │
│ IsActive            │
└─────────────────────┘
         │
         │ 1:N
         │
         ▼
┌─────────────────────┐
│   Translation       │
├─────────────────────┤
│ PublicId (PK)       │
│ Id                  │
│ TranslationKeyId(FK)│───┐
│ LanguageNo (FK)     │───┼─┐
│ Name                │   │ │
└─────────────────────┘   │ │
                          │ │
         ┌────────────────┘ │
         │                  │
         ▼                  ▼
┌─────────────────────┐   ┌─────────────────────┐
│  TranslationKey     │   │     Language        │
│  (referenced above) │   ├─────────────────────┤
└─────────────────────┘   │ Id (PK)             │
                          │ Name                │
                          │ Code                │
                          │ IsActive            │
                          └─────────────────────┘
```

## Create Flow

```
User Request
    │
    ▼
┌─────────────────────────────────────────┐
│  POST /api/shop                         │
│  { name: "Main Store", ... }            │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  CreateShopCommand                      │
└─────────────────────────────────────────┘
    │
    ├──► Create TranslationKey
    │    ┌────────────────────────────────┐
    │    │ Name: "Main Store"             │
    │    │ IsActive: true                 │
    │    └────────────────────────────────┘
    │
    └──► Create Shop
         ┌────────────────────────────────┐
         │ Name: "Main Store"             │
         │ ShopType: 0                    │
         │ Address: "123 Main St"         │
         │ ...                            │
         └────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  Save to Database                       │
└─────────────────────────────────────────┘
```

## Add Translation Flow

```
┌─────────────────────────────────────────┐
│  ITranslationService.AddTranslationAsync│
│  ("Main Store", languageNo: 2,          │
│   "Magasin Principal")                  │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  Find TranslationKey                    │
│  WHERE Name = "Main Store"              │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  Create/Update Translation              │
│  ┌────────────────────────────────────┐ │
│  │ TranslationKeyId: {key.PublicId}   │ │
│  │ LanguageNo: 2                      │ │
│  │ Name: "Magasin Principal"          │ │
│  └────────────────────────────────────┘ │
└─────────────────────────────────────────┘
```

## Retrieve Flow

```
User Request (Language: French, ID: 2)
    │
    ▼
┌─────────────────────────────────────────┐
│  GET /api/shop/{publicId}               │
│  Accept-Language: fr                    │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  GetShopByIdQuery                       │
│  userLangId = 2 (from ICurrentUser)     │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  Query:                                 │
│  1. Get Shop WHERE PublicId = {id}      │
│  2. Find TranslationKey                 │
│     WHERE Name = Shop.Name              │
│  3. Get Translation                     │
│     WHERE LanguageNo = 2                │
│  4. Return Translation.Name             │
│     OR fallback to Shop.Name            │
└─────────────────────────────────────────┘
    │
    ▼
┌─────────────────────────────────────────┐
│  Response                               │
│  {                                      │
│    "name": "Magasin Principal",         │
│    "shopType": 0,                       │
│    ...                                  │
│  }                                      │
└─────────────────────────────────────────┘
```

## Translation Lookup Logic

```
┌─────────────────────────────────────────┐
│  Shop.Name = "Main Store"               │
└─────────────────────────────────────────┘
              │
              ▼
┌─────────────────────────────────────────┐
│  Find TranslationKey                    │
│  WHERE Name = "Main Store"              │
└─────────────────────────────────────────┘
              │
              ▼
┌─────────────────────────────────────────┐
│  TranslationKey Found?                  │
└─────────────────────────────────────────┘
         │                    │
         │ Yes                │ No
         ▼                    ▼
┌──────────────────┐   ┌──────────────────┐
│ Get Translations │   │ Return Shop.Name │
│ for this key     │   │ "Main Store"     │
└──────────────────┘   └──────────────────┘
         │
         ▼
┌─────────────────────────────────────────┐
│  Translation for User's Language?       │
└─────────────────────────────────────────┘
         │                    │
         │ Yes                │ No
         ▼                    ▼
┌──────────────────┐   ┌──────────────────┐
│ Return           │   │ Return Shop.Name │
│ Translation.Name │   │ "Main Store"     │
│ "Magasin..."     │   │                  │
└──────────────────┘   └──────────────────┘
```

## Multi-Language Example

```
Shop Table:
┌────────────┬──────────────┬──────────┐
│ PublicId   │ Name         │ ShopType │
├────────────┼──────────────┼──────────┤
│ abc-123... │ Main Store   │ 0        │
└────────────┴──────────────┴──────────┘

TranslationKey Table:
┌────────────┬──────────────┐
│ PublicId   │ Name         │
├────────────┼──────────────┤
│ xyz-789... │ Main Store   │  ◄── Same value!
└────────────┴──────────────┘

Translation Table:
┌────────────┬──────────────────┬────────────┬────────────────────┐
│ PublicId   │ TranslationKeyId │ LanguageNo │ Name               │
├────────────┼──────────────────┼────────────┼────────────────────┤
│ t1-111...  │ xyz-789...       │ 1          │ Main Store         │
│ t2-222...  │ xyz-789...       │ 2          │ Magasin Principal  │
│ t3-333...  │ xyz-789...       │ 3          │ المتجر الرئيسي     │
└────────────┴──────────────────┴────────────┴────────────────────┘

Language Table:
┌────┬─────────┬──────┐
│ Id │ Name    │ Code │
├────┼─────────┼──────┤
│ 1  │ English │ en   │
│ 2  │ French  │ fr   │
│ 3  │ Arabic  │ ar   │
└────┴─────────┴──────┘
```

## Key Advantages

```
┌─────────────────────────────────────────┐
│  ✅ Generic System                      │
│  • Works with ANY entity                │
│  • No entity-specific tables            │
│  • Reusable across the application      │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│  ✅ No Foreign Keys                     │
│  • Loose coupling                       │
│  • Easy to extend                       │
│  • No cascade delete issues             │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│  ✅ Flexible                            │
│  • Add translations anytime             │
│  • Support unlimited languages          │
│  • Graceful fallback to original       │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│  ✅ Simple to Use                       │
│  • ITranslationService handles logic   │
│  • Automatic in queries                 │
│  • Minimal code required                │
└─────────────────────────────────────────┘
```
