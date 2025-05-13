# GestionDeStock - Detailed Class Relationships Diagram

## Entity Relationships Overview

```
┌───────────────────────────────────────────────────────────────────────────────────────────────────┐
│                                                                                                   │
│                                     GESTION DE STOCK SYSTEM                                       │
│                                                                                                   │
└───────────────────────────────────────────────────────────────────────────────────────────────────┘
          │                   │                      │                      │  
          │                   │                      │                      │  
          ▼                   ▼                      ▼                      ▼  
┌──────────────────┐  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────────┐
│                  │  │                 │  │                 │  │                 │
│     CATEGORY     │◄─┤     PRODUCT     │──┤     STOCK IN    │  │    STOCK OUT    │
│                  │  │                 │  │                 │  │                 │
└──────────────────┘  └─────────────────┘  └─────────────────┘  └─────────────────┘
                              │                                        │
                              └───────────────────┬────────────────────┘
                                                  │
                                                  ▼
                                        ┌─────────────────┐
                                        │                 │
                                        │      USER       │
                                        │                 │
                                        └─────────────────┘
```

## Detailed Class Relationships

```
┌───────────────────────────────────┐       ┌───────────────────────────────────┐
│              CATEGORY             │       │              PRODUCT              │
├───────────────────────────────────┤       ├───────────────────────────────────┤
│ + CategoryId: int                 │       │ + ProductId: int                  │
│ + Name: string                    │◄──────┤ + CategoryId: int                 │
│ + Description: string?            │1     *│ + Name: string                    │
└───────────────────────────────────┘       │ + Quantity: int                   │
                                            │ + PurchasePrice: decimal          │
                                            │ + SalePrice: decimal              │
                                            │ + AlertThreshold: int             │
                                            │ + Description: string?            │
                                            │ + IsOutOfStock: bool (calc)       │
                                            │ + IsLowStock: bool (calc)         │
                                            │ + IsCriticalLowStock: bool (calc) │
                                            │ + IsWarningLowStock: bool (calc)  │
                                            │ + StockStatus: string (calc)      │
                                            └───────────────────────────────────┘
                                                      │
                                            ┌─────────┴──────────┐
                                            │                    │
                                        1   ▼                1   ▼
┌───────────────────────────────────┐       ┌───────────────────────────────────┐
│             STOCK IN              │       │             STOCK OUT             │
├───────────────────────────────────┤       ├───────────────────────────────────┤
│ + StockInId: int                  │       │ + StockOutId: int                 │
│ + ProductId: int                  │       │ + ProductId: int                  │
│ + Quantity: int                   │       │ + Quantity: int                   │
│ + EntryDate: DateTime             │       │ + ExitDate: DateTime              │
│ + Supplier: string?               │       │ + Recipient: string?              │
│ + Notes: string?                  │       │ + Notes: string?                  │
└───────────────────────────────────┘       └───────────────────────────────────┘


┌───────────────────────────────────┐
│               USER                │
├───────────────────────────────────┤
│ + UserId: int                     │
│ + Username: string                │
│ + Password: string                │
│ + IsAdmin: bool                   │
└───────────────────────────────────┘
```

## Relationship Types

1. **Category to Product: One-to-Many**
   - A Category can have multiple Products
   - Each Product belongs to exactly one Category
   - Foreign key: Product.CategoryId

2. **Product to StockIn: One-to-Many**
   - A Product can have multiple StockIn records
   - Each StockIn record is for exactly one Product
   - Foreign key: StockIn.ProductId

3. **Product to StockOut: One-to-Many**
   - A Product can have multiple StockOut records
   - Each StockOut record is for exactly one Product
   - Foreign key: StockOut.ProductId

## Key Business Rules

1. **Inventory Tracking**:
   - Product Quantity = Initial Quantity + Sum(StockIn.Quantity) - Sum(StockOut.Quantity)
   - Product.Quantity must not be negative

2. **Alert System**:
   - Product.IsOutOfStock = true when Product.Quantity == 0
   - Product.IsLowStock = true when Product.Quantity <= Product.AlertThreshold
   - Different severity levels based on threshold percentages

3. **Transaction Recording**:
   - Every StockIn increases the related Product quantity
   - Every StockOut decreases the related Product quantity
   - StockOut quantity must not exceed available Product quantity

## Database Constraints

1. **Primary Keys**:
   - Category.CategoryId
   - Product.ProductId
   - StockIn.StockInId
   - StockOut.StockOutId
   - User.UserId

2. **Foreign Keys**:
   - Product.CategoryId → Category.CategoryId
   - StockIn.ProductId → Product.ProductId
   - StockOut.ProductId → Product.ProductId

3. **Required Fields**:
   - Category.Name
   - Product.Name
   - Product.Quantity
   - Product.PurchasePrice
   - Product.SalePrice
   - StockIn.Quantity
   - StockOut.Quantity
   - User.Username
   - User.Password

## Repository Interfaces

Each entity has a corresponding repository interface that defines its data access operations:

- **ICategoryRepository**: Operations for Category data
- **IProductRepository**: Operations for Product data
- **IStockMovementRepository**: Operations for StockIn and StockOut data
- **IUserRepository**: Operations for User data 