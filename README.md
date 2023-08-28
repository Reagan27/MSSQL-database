# MSSQL-database
# E-Commerce Backend System

This project implements a backend system for managing e-commerce operations. It utilizes a Microsoft SQL Server database, adheres to clean coding practices, and includes the following models: User, Products, Orders, Shipments, Payments, and Cart. Relevant relationships have been established between these models.

## Folder Structure

project-root/
│
├─ src/
│ ├── Controllers/
│ ├── Models/
│ ├── Migrations/
│ ├── appsettings.json
│ └── Program.cs
│
├─ tests/
│ ├── UnitTests/
│ └── IntegrationTests/
│
├─ README.md
└─ 
Usage
The API provides endpoints for managing Users, Products, Orders, Shipments, Payments, and Cart. Detailed usage information for each endpoint is available in the documentation.

API Endpoints
GET /api/users
GET /api/products
POST /api/orders
GET /api/shipments
POST /api/payments
GET /api/cart
