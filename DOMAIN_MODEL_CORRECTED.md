# CORRECTED DOMAIN MODEL - GROCERY SHOP MANAGEMENT SYSTEM
## All Structural Errors Fixed

---

## ISSUES FIXED

✅ **Issue 1 - Name pollution**: Created BaseAuditableEntityWithoutName for entities that don't need Name
✅ **Issue 2 - Quantity as int**: Changed all quantities to decimal (supports 1.5 kg, 0.75 liter)
✅ **Issue 3 - Enum duplication**: Removed InvoiceType and CreditStatus, consolidated into TransactionType
✅ **Issue 4 - Invoice illegal states**: Clarified with IssuerShopId + ONE of (BuyerShopId OR CustomerId)
✅ **Issue 5 - Payment multiple owners**: Added PaymentType to clarify, business logic enforces single reference
✅ **Issue 6 - Derived fields**: Removed all derived fields (PaidAmount, BalanceAmount, DaysOverdue, Status)
✅ **Issue 7 - String types**: Replaced MovementType and ReferenceType strings with enums
✅ **Issue 8 - PublicId clarity**: Kept as string GUID for external API exposure, Id remains int for internal FK

---

## BASE ENTITIES

### BaseEntity (existing - for entities WITH Name)
- Id (int, PK)
- PublicId (string, GUID) - for external API exposure
- Name (string)
- IsPublic (bool, default: false)

### BaseAuditableEntity (existing - for entities WITH Name)
Inherits: BaseEntity
- CreatedBy (int?, nullable)
- CreatedDate (DateTime?, default: DateTime.Now)
- UpdatedBy (int?, nullable)
- UpdatedDate (DateTime?, default: DateTime.Now)

### BaseAuditableEntityWithoutName (NEW - for entities WITHOUT Name)
- Id (int, PK)
- PublicId (string, GUID)
- IsPublic (bool, default: false)
- CreatedBy (int?, nullable)
- CreatedDate (DateTime?, default: DateTime.Now)
- UpdatedBy (int?, nullable)
- UpdatedDate (DateTime?, default: DateTime.Now)

---

## ENUMS

### ShopType
- RetailShop = 1
- WholesaleShop = 2

### TransactionType (CONSOLIDATED - replaces InvoiceType, CreditStatus overlap)
- Sale = 1
- Purchase = 2
- Return = 3
- CashPayment = 4
- CreditPayment = 5
- CreditIssued = 6
- CreditAdjustment = 7

### PaymentStatus (existing)
- Paid = 1
- Partial = 2
- Unpaid = 3

### MovementType (NEW - replaces string)
- Purchase = 1
- Sale = 2
- Adjustment = 3
- Return = 4
- Damage = 5
- Transfer = 6

### ReferenceType (NEW - replaces string)
- Invoice = 1
- Adjustment = 2
- Transfer = 3
- Manual = 4

---

## ENTITIES

### 1. Shop
**Inherits:** BaseAuditableEntity (HAS Name - shop needs a name)

**Properties:**
- ShopType (enum: RetailShop/WholesaleShop)
- Address (string)
- PhoneNumber (string)
- Email (string)
- TaxNumber (string)
- IsActive (bool, default: true)

**Navigation Properties:**
- Products (Collection<Product>)
- IssuedInvoices (Collection<Invoice>) - invoices this shop created
- PurchasedInvoices (Collection<Invoice>) - invoices this shop received
- Customers (Collection<Customer>)
- CreditAccountsAsCreditor (Collection<ShopCreditAccount>)
- CreditAccountsAsDebtor (Collection<ShopCreditAccount>)

**Business Rules:**
- Name is required (shop must have a name)
- ShopType determines available features

---

### 2. Product
**Inherits:** BaseAuditableEntity (HAS Name - product needs a name)

**Properties:**
- ShopId (int, FK)
- SKU (string)
- Description (string)
- Category (string)
- UnitPrice (decimal)
- StockQuantity (decimal) ✅ FIXED: was int, now decimal
- ReorderLevel (decimal) ✅ FIXED: was int, now decimal
- Unit (string) - piece, kg, liter, etc.
- IsActive (bool, default: true)

**Navigation Properties:**
- Shop (Shop)
- InvoiceItems (Collection<InvoiceItem>)
- StockMovements (Collection<StockMovement>)

**Business Rules:**
- Name is required (product must have a name)
- Decimal quantities support fractional units (1.5 kg, 0.75 liter)

---

### 3. Customer
**Inherits:** BaseAuditableEntity (HAS Name - customer needs a name)

**Properties:**
- ShopId (int, FK)
- PhoneNumber (string)
- Address (string)
- NationalId (string)
- CreditLimit (decimal)
- IsActive (bool, default: true)

**Navigation Properties:**
- Shop (Shop)
- Invoices (Collection<Invoice>)
- CreditAccounts (Collection<CustomerCreditAccount>)

**Business Rules:**
- Name is required (customer must have a name)
- CreditLimit enforced by business logic

---

### 4. Invoice
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- InvoiceNumber (string)
- TransactionType (enum) ✅ FIXED: was InvoiceType, now TransactionType
- InvoiceDate (DateTime)
- DueDate (DateTime)
- IssuerShopId (int, FK) ✅ FIXED: was SupplierShopId, clearer naming
- BuyerShopId (int?, FK, nullable) - for B2B transactions
- CustomerId (int?, FK, nullable) - for B2C transactions
- SubTotal (decimal)
- TaxAmount (decimal)
- DiscountAmount (decimal)
- TotalAmount (decimal)
- Notes (string)

**REMOVED (derived fields):** ✅ FIXED
- ~~PaidAmount~~ - calculate from Payments.Sum(p => p.Amount)
- ~~BalanceAmount~~ - calculate as TotalAmount - PaidAmount
- ~~PaymentStatus~~ - calculate from balance

**Navigation Properties:**
- IssuerShop (Shop)
- BuyerShop (Shop, nullable)
- Customer (Customer, nullable)
- InvoiceItems (Collection<InvoiceItem>)
- Payments (Collection<Payment>)

**Business Rules:** ✅ FIXED
- IssuerShopId is ALWAYS required
- EXACTLY ONE of (BuyerShopId OR CustomerId) must be set, not both, not neither
- Enforced by business logic/validation layer

**Calculated Properties (not stored):**
- PaidAmount = Payments.Sum(p => p.Amount)
- BalanceAmount = TotalAmount - PaidAmount
- PaymentStatus = BalanceAmount == 0 ? Paid : (PaidAmount > 0 ? Partial : Unpaid)

---

### 5. InvoiceItem
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- InvoiceId (int, FK)
- ProductId (int, FK)
- Quantity (decimal) ✅ FIXED: was int, now decimal
- UnitPrice (decimal)
- DiscountAmount (decimal)
- TaxAmount (decimal)
- TotalAmount (decimal)

**Navigation Properties:**
- Invoice (Invoice)
- Product (Product)

**Business Rules:**
- Decimal quantity supports fractional units

---

### 6. Payment
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- PaymentNumber (string)
- PaymentType (TransactionType) ✅ FIXED: added to clarify payment context
- InvoiceId (int?, FK, nullable)
- CustomerCreditAccountId (int?, FK, nullable)
- ShopCreditAccountId (int?, FK, nullable)
- PaymentDate (DateTime)
- Amount (decimal)
- PaymentMethod (string) - Cash, Bank Transfer, Mobile Money
- ReferenceNumber (string)
- Notes (string)

**Navigation Properties:**
- Invoice (Invoice, nullable)
- CustomerCreditAccount (CustomerCreditAccount, nullable)
- ShopCreditAccount (ShopCreditAccount, nullable)

**Business Rules:** ✅ FIXED
- EXACTLY ONE of (InvoiceId, CustomerCreditAccountId, ShopCreditAccountId) must be set
- Enforced by business logic/validation layer
- PaymentType clarifies the context (CashPayment, CreditPayment)

---

### 7. CustomerCreditAccount
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- CustomerId (int, FK)
- ShopId (int, FK)
- AccountOpenDate (DateTime) ✅ FIXED: was CreditDate, clearer naming
- CreditLimit (decimal)
- Notes (string)

**REMOVED (derived fields):** ✅ FIXED
- ~~TotalCreditAmount~~ - calculate from Transactions
- ~~PaidAmount~~ - calculate from Payments
- ~~BalanceAmount~~ - calculate as TotalCreditAmount - PaidAmount
- ~~Status~~ - calculate from balance and dates
- ~~LastPaymentDate~~ - calculate from Payments.Max(p => p.PaymentDate)
- ~~DaysOverdue~~ - calculate from invoices and current date

**Navigation Properties:**
- Customer (Customer)
- Shop (Shop)
- Payments (Collection<Payment>)
- Transactions (Collection<CustomerCreditTransaction>)

**Calculated Properties (not stored):**
- TotalCreditAmount = Transactions.Where(t => t.TransactionType == CreditIssued).Sum(t => t.Amount)
- PaidAmount = Payments.Sum(p => p.Amount)
- BalanceAmount = TotalCreditAmount - PaidAmount
- LastPaymentDate = Payments.Max(p => p.PaymentDate)
- DaysOverdue = calculate based on invoice due dates
- Status = derived from BalanceAmount and DaysOverdue

---

### 8. CustomerCreditTransaction
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- CustomerCreditAccountId (int, FK)
- TransactionDate (DateTime)
- TransactionType (enum) - CreditIssued, CreditAdjustment, etc.
- Amount (decimal)
- BalanceAfter (decimal) - snapshot for audit trail
- Description (string)
- ReferenceNumber (string)

**Navigation Properties:**
- CustomerCreditAccount (CustomerCreditAccount)

**Business Rules:**
- BalanceAfter is a snapshot for audit purposes, not source of truth

---

### 9. ShopCreditAccount
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- CreditorShopId (int, FK) - wholesale shop giving credit
- DebtorShopId (int, FK) - retail shop receiving credit
- AccountOpenDate (DateTime) ✅ FIXED: was CreditDate, clearer naming
- CreditLimit (decimal)
- InterestRate (decimal)
- Terms (string)
- Notes (string)

**REMOVED (derived fields):** ✅ FIXED
- ~~TotalCreditAmount~~ - calculate from Transactions
- ~~PaidAmount~~ - calculate from Payments
- ~~BalanceAmount~~ - calculate as TotalCreditAmount - PaidAmount
- ~~Status~~ - calculate from balance and dates
- ~~LastPaymentDate~~ - calculate from Payments.Max(p => p.PaymentDate)
- ~~DaysOverdue~~ - calculate from invoices and current date

**Navigation Properties:**
- CreditorShop (Shop)
- DebtorShop (Shop)
- Payments (Collection<Payment>)
- Transactions (Collection<ShopCreditTransaction>)

**Calculated Properties (not stored):**
- TotalCreditAmount = Transactions.Where(t => t.TransactionType == CreditIssued).Sum(t => t.Amount)
- PaidAmount = Payments.Sum(p => p.Amount)
- BalanceAmount = TotalCreditAmount - PaidAmount
- LastPaymentDate = Payments.Max(p => p.PaymentDate)
- DaysOverdue = calculate based on invoice due dates
- Status = derived from BalanceAmount and DaysOverdue

---

### 10. ShopCreditTransaction
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- ShopCreditAccountId (int, FK)
- TransactionDate (DateTime)
- TransactionType (enum) - CreditIssued, CreditAdjustment, etc.
- Amount (decimal)
- BalanceAfter (decimal) - snapshot for audit trail
- Description (string)
- ReferenceNumber (string)

**Navigation Properties:**
- ShopCreditAccount (ShopCreditAccount)

**Business Rules:**
- BalanceAfter is a snapshot for audit purposes, not source of truth

---

### 11. StockMovement
**Inherits:** BaseAuditableEntityWithoutName ✅ FIXED: no Name

**Properties:**
- ProductId (int, FK)
- ShopId (int, FK)
- MovementDate (DateTime)
- MovementType (enum) ✅ FIXED: was string, now enum
- Quantity (decimal) ✅ FIXED: was int, now decimal
- QuantityBefore (decimal) ✅ FIXED: was int, now decimal
- QuantityAfter (decimal) ✅ FIXED: was int, now decimal
- ReferenceType (enum) ✅ FIXED: was string, now enum
- ReferenceId (int?, nullable)
- Notes (string)

**Navigation Properties:**
- Product (Product)
- Shop (Shop)

**Business Rules:**
- Decimal quantities support fractional units
- Type-safe enums prevent invalid values

---

## KEY RELATIONSHIPS

**Shop → Product:** One-to-Many  
**Shop → Customer:** One-to-Many  
**Shop → Invoice (as Issuer):** One-to-Many  
**Shop → Invoice (as Buyer):** One-to-Many  
**Shop → ShopCreditAccount (as Creditor):** One-to-Many  
**Shop → ShopCreditAccount (as Debtor):** One-to-Many  

**Customer → Invoice:** One-to-Many  
**Customer → CustomerCreditAccount:** One-to-Many  

**Invoice → InvoiceItem:** One-to-Many  
**Invoice → Payment:** One-to-Many  

**Product → InvoiceItem:** One-to-Many  
**Product → StockMovement:** One-to-Many  

**CustomerCreditAccount → Payment:** One-to-Many  
**CustomerCreditAccount → CustomerCreditTransaction:** One-to-Many  

**ShopCreditAccount → Payment:** One-to-Many  
**ShopCreditAccount → ShopCreditTransaction:** One-to-Many

---

## BUSINESS LOGIC CONSTRAINTS (enforced in Application Layer)

1. **Invoice Party Validation:**
   - IssuerShopId is required
   - EXACTLY ONE of (BuyerShopId OR CustomerId) must be set

2. **Payment Reference Validation:**
   - EXACTLY ONE of (InvoiceId, CustomerCreditAccountId, ShopCreditAccountId) must be set

3. **Quantity Validation:**
   - All quantities must be > 0
   - Decimal precision supports fractional units

4. **Credit Limit Enforcement:**
   - Customer credit balance cannot exceed CreditLimit
   - Shop credit balance cannot exceed CreditLimit

5. **Stock Validation:**
   - StockQuantity cannot go negative (except for specific MovementTypes like Damage)

6. **Derived Field Calculation:**
   - All balances, statuses, and dates calculated on-demand from source data
   - No stored derived fields to prevent data inconsistency

---

## DESIGN PRINCIPLES APPLIED

✅ **Single Source of Truth:** No derived fields stored  
✅ **Type Safety:** Enums instead of strings  
✅ **Semantic Clarity:** Entities only have properties that make sense  
✅ **Decimal Precision:** Support for fractional quantities  
✅ **Constraint Enforcement:** Business rules prevent illegal states  
✅ **Audit Trail:** All entities track creation and modification  
✅ **Flexibility:** PublicId for external APIs, Id for internal FKs  

---

## IMPLEMENTATION NOTES

1. **Calculated Properties:** Implement as computed properties in entity classes or use LINQ queries
2. **Validation:** Use FluentValidation in Application layer to enforce business rules
3. **EF Core Configuration:** Use Fluent API to configure relationships and constraints
4. **Performance:** Add indexes on FK columns and frequently queried fields
5. **Concurrency:** Use RowVersion/Timestamp for optimistic concurrency control

---

END OF CORRECTED DOMAIN MODEL
