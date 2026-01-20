# Shop API Endpoints

## Base URL
`/api/shop`

## Endpoints

### 1. Create Shop
**POST** `/api/shop`

**Request Body:**
```json
{
  "name": "Main Store",
  "shopType": 0,
  "address": "123 Main Street",
  "phoneNumber": "+1234567890",
  "email": "store@example.com",
  "taxNumber": "TAX123456",
  "isActive": true
}
```

**Response:** `200 OK`
```json
{
  "name": "Main Store",
  "shopType": 0,
  "address": "123 Main Street",
  "phoneNumber": "+1234567890",
  "email": "store@example.com",
  "taxNumber": "TAX123456",
  "isActive": true
}
```

---

### 2. Get All Shops (Paginated)
**GET** `/api/shop?pageNumber=1&pageSize=25`

**Query Parameters:**
- `pageNumber` (optional, default: 1)
- `pageSize` (optional, default: 25)

**Response:** `200 OK`
```json
{
  "items": [
    {
      "publicId": "guid-string",
      "id": 1,
      "name": "Main Store",
      "shopType": 0,
      "address": "123 Main Street",
      "phoneNumber": "+1234567890",
      "email": "store@example.com",
      "taxNumber": "TAX123456",
      "isActive": true
    }
  ],
  "pageNumber": 1,
  "pageSize": 25,
  "totalCount": 1,
  "totalPages": 1
}
```

---

### 3. Get Shop by ID
**GET** `/api/shop/{publicId}`

**Response:** `200 OK`
```json
{
  "publicId": "guid-string",
  "id": 1,
  "name": "Main Store",
  "shopType": 0,
  "address": "123 Main Street",
  "phoneNumber": "+1234567890",
  "email": "store@example.com",
  "taxNumber": "TAX123456",
  "isActive": true
}
```

**Response:** `404 Not Found` (if shop doesn't exist)

---

### 4. Update Shop
**PUT** `/api/shop/{publicId}`

**Request Body:**
```json
{
  "name": "Updated Store Name",
  "shopType": 1,
  "address": "456 New Street",
  "phoneNumber": "+9876543210",
  "email": "updated@example.com",
  "taxNumber": "TAX654321",
  "isActive": true
}
```

**Response:** `200 OK`
```json
{
  "publicId": "guid-string",
  "id": 1,
  "name": "Updated Store Name",
  "shopType": 1,
  "address": "456 New Street",
  "phoneNumber": "+9876543210",
  "email": "updated@example.com",
  "taxNumber": "TAX654321",
  "isActive": true
}
```

---

### 5. Delete Shop
**DELETE** `/api/shop/{publicId}`

**Response:** `200 OK`

**Response:** `404 Not Found` (if shop doesn't exist)

---

## ShopType Enum Values
```csharp
public enum ShopType
{
    Retail = 0,
    Wholesale = 1,
    Both = 2
}
```

## Translation Support

All GET endpoints automatically return translated `name` values based on the user's language preference (from `ICurrentUser.GetLangId()`).

If no translation exists for the user's language, the original name is returned.

## Error Responses

### 400 Bad Request
```json
{
  "errors": [
    {
      "code": "ERROR_CODE",
      "message": "Error description"
    }
  ]
}
```

### 404 Not Found
```json
{
  "errors": [
    {
      "code": "NOT_FOUND",
      "message": "Resource not found"
    }
  ]
}
```

### 409 Conflict
```json
{
  "errors": [
    {
      "code": "DUPLICATE",
      "message": "Resource already exists"
    }
  ]
}
```
