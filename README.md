# 📊 Gestion-De-Stock: Inventory Management System

> A modern inventory management system built with C# and Entity Framework Core

## 📋 Table of Contents

- [Overview](#-overview)
- [Architecture](#-architecture)
- [Features](#-features)
- [Data Model](#-data-model)
- [Business Logic](#-business-logic)
- [User Interface](#-user-interface)
- [Technical Stack](#-technical-stack)
- [Getting Started](#-getting-started)
- [Screenshots](#-screenshots)

## 🔍 Overview

Gestion-De-Stock is a comprehensive inventory management application designed to help businesses track their stock levels, manage product categories, and record stock movements (both inflows and outflows). The system provides real-time alerts for low stock items and offers detailed reporting capabilities.

## 🏗️ Architecture

The application follows a modern layered architecture:

```
┌─────────────────────────────────────────────────────┐
│                                                     │
│                 📱 Presentation Layer               │
│         (Windows Forms UI, User Interface)          │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                  🧠 Business Layer                  │
│         (Services, Business Logic, Validation)      │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                 💾 Data Access Layer                │
│         (Repositories, Entity Framework Core)       │
│                                                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│                   🗃️ Data Storage                   │
│                 (SQLite Database)                   │
│                                                     │
└─────────────────────────────────────────────────────┘
```

### Key Architectural Patterns

- **🔄 Repository Pattern**: Abstracts data access operations
- **💉 Dependency Injection**: Promotes loose coupling between components
- **📝 CRUD Operations**: Standard Create, Read, Update, Delete operations
- **🚨 Notification System**: Alerts for low and out-of-stock products

## ✨ Features

- **📦 Product Management**
  - Add, update, and delete products
  - Categorize products
  - Track purchase and sale prices
  - Set alert thresholds for low stock warnings

- **🗂️ Category Management**
  - Create and manage product categories
  - Organize inventory by category

- **📥 Stock-In Operations**
  - Record inventory additions
  - Track suppliers and entry dates
  - Add notes for each stock entry

- **📤 Stock-Out Operations**
  - Record inventory removals
  - Track recipients and exit dates
  - Add notes for each stock removal

- **⚠️ Stock Alerts**
  - Real-time monitoring of inventory levels
  - Visual indicators for out-of-stock items
  - Warning system for low stock with multiple severity levels
  - Quick restock capabilities from the alert interface

- **👤 User Authentication**
  - Secure login system
  - Admin privileges for sensitive operations

## 📊 Data Model

The core entities in the system include:

### 📋 Category
- **Properties**:
  - CategoryId (Primary Key)
  - Name
  - Description
- **Relationships**:
  - One-to-Many with Products

### 📦 Product
- **Properties**:
  - ProductId (Primary Key)
  - Name
  - Quantity
  - PurchasePrice
  - SalePrice
  - AlertThreshold
  - Description
  - CategoryId (Foreign Key)
- **Computed Properties**:
  - IsOutOfStock
  - IsLowStock
  - IsCriticalLowStock
  - IsWarningLowStock
  - StockStatus
- **Relationships**:
  - Many-to-One with Category
  - One-to-Many with StockIn and StockOut

### 📥 StockIn
- **Properties**:
  - StockInId (Primary Key)
  - ProductId (Foreign Key)
  - Quantity
  - EntryDate
  - Supplier
  - Notes
- **Relationships**:
  - Many-to-One with Product

### 📤 StockOut
- **Properties**:
  - StockOutId (Primary Key)
  - ProductId (Foreign Key)
  - Quantity
  - ExitDate
  - Recipient
  - Notes
- **Relationships**:
  - Many-to-One with Product

### 👤 User
- **Properties**:
  - UserId (Primary Key)
  - Username
  - Password
  - IsAdmin

## 🧠 Business Logic

### 🧮 Inventory Calculation
- Product quantity is calculated as: Initial Quantity + Sum(StockIn.Quantity) - Sum(StockOut.Quantity)
- The system prevents negative inventory (can't remove more than available)

### 🚨 Alert System
- Products are flagged as out of stock when Quantity = 0
- Low stock warning when Quantity ≤ AlertThreshold
- Multiple severity levels based on threshold percentages:
  - Critical level: ≤ 25% of threshold
  - Warning level: ≤ 50% of threshold

### 📝 Transaction Validation
- StockOut quantity must not exceed available Product quantity
- Required fields are validated before saving (Product name, quantity, etc.)
- Price validation (sale price should typically be higher than purchase price)

## 🖥️ User Interface

The application features a modern, responsive Windows Forms interface:

- **🏠 Dashboard**: Central hub showing key metrics and navigation
- **📋 Category Management**: Form for CRUD operations on categories
- **📦 Product Management**: Comprehensive product listing and details
- **📥 Stock-In Form**: Record and view inventory additions
- **📤 Stock-Out Form**: Record and view inventory removals
- **🚨 Alerts Center**: View and manage low-stock and out-of-stock items

## 🛠️ Technical Stack

- **🔤 Language**: C# (.NET 8.0)
- **🖼️ UI Framework**: Windows Forms
- **🗃️ ORM**: Entity Framework Core
- **💾 Database**: SQLite
- **🔄 Patterns**: Repository Pattern, Dependency Injection

## 🚀 Getting Started

1. **Clone the repository**
   ```
   git clone https://github.com/yourusername/Gestion-De-Stock.git
   ```

2. **Open the solution in Visual Studio**
   - Double-click on the `GestionDeStock.sln` file

3. **Restore NuGet packages**
   ```
   dotnet restore
   ```

4. **Build the solution**
   ```
   dotnet build
   ```

5. **Run the application**
   ```
   dotnet run --project GestionDeStock
   ```

6. **Default Login Credentials**
   - Username: `admin`
   - Password: `admin`

## 📸 Screenshots



---

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

