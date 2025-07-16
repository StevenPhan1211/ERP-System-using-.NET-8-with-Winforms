# ERP System using .NET 8 with Clean Architecture and Winforms

A desktop-based Enterprise Resource Planning (ERP) system designed to manage internal operations such as inventory, sales, customer relations, and reporting. The solution follows Clean Architecture principles, focusing on scalability, testability, and maintainability.

---

## 📌 Overview

This solution consists of two main components:

- **Backend API**: Built with **.NET 8** using **Clean Architecture** and **Object-Oriented Programming (OOP)** principles to ensure separation of concerns and high testability.
- **Frontend**: Developed using **Windows Forms (.NET Framework 4.8)** for a responsive desktop experience.
- **Database**: Uses **Microsoft SQL Server** for reliable relational data management.
- **Development Environment**: Visual Studio 2022

---

## ⚙️ Features

- 🔐 User authentication & role-based access
- 📦 Product, inventory, customer, and order management
- 📊 Revenue and sales reporting by time period
- 🔄 Synchronous data exchange via RESTful API
- 🏗️ Scalable and modular codebase using Clean Architecture

---

## 📁 Solution Structure

```bash
HTHGroup_ERP/
│
├── Backend/              # .NET 8 Web API following Clean Architecture
│   ├── Domain/           # Business entities and interfaces
│   ├── Application/      # Use cases and DTOs
│   ├── Infrastructure/   # Data access & external services
│   └── Presentation/     # API Controllers
│
├── Frontend/             # WinForms UI (.NET Framework 4.8)
│   ├── BLL/   # Bussiness Logic Layer to get API endpoints
│   └── DAL/   # User Interfaces
├── packages/             # NuGet packages (if used offline)
├── HTHGroup_ERP.sln      # Visual Studio solution file
└── README.md

```

---

## 🛠️ Setup Instructions
Prerequisites

✅ Visual Studio 2022

✅ .NET 8 SDK

✅ .NET Framework 4.8 Developer Pack

✅ Microsoft SQL Server (Local or Remote)

---

## How to Run

# Run Backend
1. Open Backend project in Visual Studio 2022
2. Restore NuGet packages
3. Set `Presentation` project as startup
4. Run the API

# Run Frontend
1. Open Frontend project (WinForms) in Visual Studio 2022
2. Build and run

# Setup Database
- Update connection strings in `appsettings.json`
- Run EF Core migrations or SQL scripts (if provided)
