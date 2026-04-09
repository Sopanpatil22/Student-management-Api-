Student Management System API (ASP.NET Core)
📖 Description

A secure and scalable RESTful API built using ASP.NET Core to manage student records. The system supports full CRUD operations and is designed with a layered architecture to ensure maintainability and separation of concerns.

It includes JWT-based authentication, global exception handling, logging, and interactive API documentation via Swagger.

🚀 Features
CRUD operations for students
JWT Authentication & Authorization
Global Exception Handling (custom middleware)
Structured Logging (Serilog / built-in logging)
Swagger UI for API testing
Clean Layered Architecture
🛠️ Tech Stack
Backend: ASP.NET Core
Language: C#
ORM: Entity Framework Core
Database: SQL Server
Auth: JWT Bearer Tokens
Documentation: Swagger (Swashbuckle)

🏗️ Architecture
Controller → Service → Repository → Database
Controller → Handles HTTP requests
Service → Business logic
Repository → Database operations

🗄️ Database Schema
Student Table
Column	Type
Id	int (PK)
Name	string
Email	string
Age	int
Course	string
CreatedDate	datetime

🔐 Authentication (JWT)
Flow:
User logs in → gets JWT token
Token is passed in headers:
Authorization: Bearer <token>
Protected endpoints validate token

🔗 API Endpoints
🔓 Public
POST /api/auth/login

🔐 Protected
GET     /api/students
GET     /api/students/{id}
POST    /api/students
PUT     /api/students/{id}
DELETE  /api/students/{id}

⚙️ Setup Instructions
1. Clone Repository
git clone https://github.com/your-username/student-management-api.git
cd student-management-api

3. Configure Database

Update appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;"
}

3. Run Migrations
dotnet ef migrations add InitialCreate
dotnet ef database update
4. Run Application
dotnet run

Swagger:

https://localhost:<port>/swagger
🧱 Project Structure
StudentManagementAPI/
│── Controllers/
│── Services/
│── Repositories/
│── Models/
│── DTOs/
│── Middleware/
│── Data/
│── appsettings.json
│── Program.cs


⚠️ Global Exception Handling (Middleware)
Centralized error handling
Returns consistent API responses
Prevents application crash

📊 Logging
Integrated logging using Serilog / built-in logger
Logs requests, errors, and system events
