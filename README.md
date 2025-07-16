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
├── Backend/                  # .NET 8 Web API with Clean Architecture
│   ├── ERP.Infrastructure/   # Data access & external services
│   ├── ERP.Core/             # Business entities and interfaces
│   ├── ERP.Application/      # Use cases and DTOs
│   └── ERP.Api/              # API Controllers
│
├── Frontend/             # WinForms UI (.NET Framework 4.8)
│   ├── BLL/              # Bussiness Logic Layer to get API endpoints
│   └── DAL/              # User Interfaces (Winforms)
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

✅ Microsoft SQL Server 2022 (I am using Developer version)

---

# How to Run Project

## Run Backend
1. Open Visual Studio 2022
2. Clone this Repository by using command `https://github.com/StevenPhan1211/ERP-System-using-.NET-8-with-Winforms.git`
3. Restore NuGet packages
4. Because I am using Code-first to generate database in Microsoft SQL Server 2022 so you should go to `appsettings.json` in `ERP.Api` layer to adjust your connection strings
5. Open `Tools` --> `NuGet Package Manager` --> `Package Manager Console` --> Choose Default Project `ERP.Infrastructure` and run this command `Update-Database` then voilà! You have successfully migrated database
6. Run the API

## Before you want to use this UI layer
This project is using DevExpress to create Winforms application as Frontend. Make sure you have installed DevExpress in your computer. If not, go to DevExpress page `https://www.devexpress.com/` to install it. After installed it, you're good to go

## Run Frontend
1. Open Frontend project (WinForms) in Visual Studio 2022
2. Build and run
