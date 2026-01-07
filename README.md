


# 🏦 Bank Management System

## 📋 Overview
A comprehensive desktop application built with C# and Windows Forms that implements a three-tier architecture for managing banking operations. The system provides secure client management, user authentication, transaction processing, and currency exchange functionality.

## 🏗️ Architecture

### 🔷 Three-Tier Design
- **Presentation Layer** - Windows Forms UI with custom controls (Guna.UI2, Krypton Toolkit, Siticone)
- **Business Logic Layer** - Core business rules and data validation
- **Data Access Layer** - Database connectivity and CRUD operations

## ✨ Features

```markdown

## 🏷️ Badges

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

</div>
```


- **Client Management** - Add, update, delete, and search client records
- **User Management** - Role-based user administration with permissions
- **Transactions** - Transfer processing and transaction history
- **Currency Exchange** - Real-time currency conversion and rates
- **Authentication** - Secure login system with user validation
- **Permissions System** - Granular access control for users

## 🛠️ Tech Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C#
- **UI Libraries**: Guna.UI2, Krypton Toolkit, Siticone
- **Database**: SQL Server (via clsBankDataAccessSettings)

## 📁 Project Structure

```
├── Bank Management System (Presentation)
├── Bank Business Logic Layer
└── Bank Data Access Layer
```

## 🚀 Getting Started

1. Clone the repository
2. Open `Bank Management System.sln` in Visual Studio
3. Restore NuGet packages
4. Configure database connection in `clsBankDataAccessSettings.cs`
5. Build and run

