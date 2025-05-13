# GestionDeStock - Entity Class Diagram

This diagram focuses exclusively on the entity classes (data models) and their relationships.

```mermaid
classDiagram
    %% Entity Classes with all properties
    class Category {
        +int CategoryId
        +string Name
        +string? Description
        +ICollection~Product~ Products
    }
    
    class Product {
        +int ProductId
        +string Name
        +int Quantity
        +decimal PurchasePrice
        +decimal SalePrice
        +int AlertThreshold
        +string? Description
        +int CategoryId
        +bool IsOutOfStock
        +bool IsLowStock
        +bool IsCriticalLowStock
        +bool IsWarningLowStock
        +string StockStatus
        +Category Category
        +ICollection~StockIn~ StockIns
        +ICollection~StockOut~ StockOuts
    }
    
    class StockIn {
        +int StockInId
        +int ProductId
        +int Quantity
        +DateTime EntryDate
        +string? Supplier
        +string? Notes
        +Product Product
    }
    
    class StockOut {
        +int StockOutId
        +int ProductId
        +int Quantity
        +DateTime ExitDate
        +string? Recipient
        +string? Notes
        +Product Product
    }
    
    class User {
        +int UserId
        +string Username
        +string Password
        +bool IsAdmin
    }
    
    %% Entity Relationships with cardinality and descriptions
    Category "1" <-- "*" Product : has >
    Product "1" <-- "*" StockIn : records addition to >
    Product "1" <-- "*" StockOut : records removal from >
```

## Relationship Details

### One-to-Many: Category to Product
- Each Category can contain multiple Products
- Each Product belongs to exactly one Category
- Foreign key: `Product.CategoryId` references `Category.CategoryId`

### One-to-Many: Product to StockIn
- Each Product can have multiple StockIn records
- Each StockIn record is associated with exactly one Product
- Foreign key: `StockIn.ProductId` references `Product.ProductId`

### One-to-Many: Product to StockOut
- Each Product can have multiple StockOut records
- Each StockOut record is associated with exactly one Product
- Foreign key: `StockOut.ProductId` references `Product.ProductId`

## Key Business Logic

### Product Stock Management
- `Product.Quantity`: Current quantity in stock
- `Product.PurchasePrice`: Cost price of the product
- `Product.SalePrice`: Selling price of the product
- `Product.AlertThreshold`: Minimum quantity threshold for alerts

### Computed Properties
- `Product.IsOutOfStock`: True when Quantity = 0
- `Product.IsLowStock`: True when Quantity ≤ AlertThreshold
- `Product.IsCriticalLowStock`: True when Quantity ≤ (AlertThreshold × 0.25)
- `Product.IsWarningLowStock`: True when Quantity ≤ (AlertThreshold × 0.5) and not critical
- `Product.StockStatus`: Text representation of stock status ("Out of Stock", "Critical Level", etc.) 