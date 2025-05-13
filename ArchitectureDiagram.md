# GestionDeStock - Architecture Overview

## 1. Layered Architecture

GestionDeStock follows a classic layered architecture pattern with clear separation of concerns:

---

## 2. Core Layers

```
┌─────────────────────────────────────────────────────┐
│                                                     │
│                 Presentation Layer                  │
│         (Windows Forms UI, User Interface)          │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                  Business Layer                     │
│         (Services, Business Logic, Validation)      │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                   Data Access Layer                 │
│         (Repositories, Entity Framework Core)       │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                   Data Storage                      │
│             (SQLite Database)                       │
│                                                     │
└─────────────────────────────────────────────────────┘
```

---

## 3. Key Components

### Data Models (Entities)
- **Product**: Core entity for inventory items with properties for tracking stock levels
- **Category**: Grouping classification for products
- **StockIn**: Records for inventory additions
- **StockOut**: Records for inventory removals
- **User**: Authentication and authorization information

### Data Access
- **Repository Pattern**: Abstracts data access operations
- **Entity Framework Core**: ORM used to interact with SQLite database
- **Database Context**: Central configuration for entity mapping and relationships

### Business Logic
- **Inventory Management**: Stock tracking, alerts for low inventory
- **Transaction Processing**: Handling stock movements (in/out)
- **Data Validation**: Business rules enforcement

### User Interface
- **Forms-based UI**: Windows Forms implementation for desktop experience
- **Dashboard**: Central navigation hub
- **Management Forms**: Dedicated forms for each entity type
- **Transaction Forms**: Forms for recording stock movements

---

## 4. Key Relationships

```
┌─────────────┐     belongs to     ┌─────────────┐
│   Product   │───────────────────▶│  Category   │
└─────────────┘                    └─────────────┘
       ▲
       │ has many
       │
┌─────────────┐                   ┌─────────────┐
│   StockIn   │                   │  StockOut   │
└─────────────┘                   └─────────────┘
```

---

## 5. Application Flow

```
                                ┌───────────────┐
                      ┌────────▶│ Category Form │
                      │         └───────────────┘
                      │
                      │         ┌───────────────┐
                      ├────────▶│ Product Form  │
┌─────────┐   opens   │         └───────────────┘
│  Login  │───────────┤
└─────────┘           │         ┌───────────────┐
                      ├────────▶│  StockIn Form │
                      │         └───────────────┘
                      │
                      │         ┌───────────────┐
                      ├────────▶│ StockOut Form │
                      │         └───────────────┘
                      │
                      │         ┌───────────────┐
                      └────────▶│  Alert Form   │
                                └───────────────┘
```

---

## 6. Technologies Used

- **Frontend**: Windows Forms (.NET 8.0)
- **Backend**: C# (.NET 8.0)
- **ORM**: Entity Framework Core
- **Database**: SQLite
- **Dependency Injection**: Native .NET DI Container

---

## 7. Architectural Patterns

- **Repository Pattern**: Abstracts data access operations
- **Dependency Injection**: Promotes loose coupling between components
- **CRUD Operations**: Standard Create, Read, Update, Delete operations for entities
- **Notification System**: Alerts for low and out-of-stock products

---

## 8. Data Flow

```
┌─────────┐     ┌────────────┐     ┌─────────────┐     ┌──────────┐
│   UI    │────▶│ Repository │────▶│ DbContext   │────▶│ Database │
└─────────┘     └────────────┘     └─────────────┘     └──────────┘
     ▲               │                                       │
     └───────────────┴───────────────────────────────────────┘
                           Data returns
``` 