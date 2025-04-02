# ChatApp Backend API

This is the backend API for a real-time chat application built with **ASP.NET Core 8 Web API**. It provides user authentication, message handling, and conversation management endpoints to support the frontend of a modern chat application.

## 🚀 Features

- JWT-based authentication
- Create, join, and leave conversations
- Real-time message sending and receiving (SignalR)
- RESTful API architecture
- Entity Framework Core for data access

## 🧰 Technologies Used

- .NET 8 (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server
- JWT Authentication
- AutoMapper
- Swagger (OpenAPI)

---

## 📦 Getting Started

Follow the steps below to clone, set up, and run the API project locally.

### ✅ Prerequisites

Make sure you have the following installed on your machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or use SQLite for local development)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- Swagger for API testing 

---

### 📁 1. Clone the Repository

```bash
git clone https://github.com/canturane/Chatapp_Backend.git

### 📁 2. Clone the Repository

cd Chatapp_Backend

---

### 📁 3. Configure database

"ConnectionStrings": {
  "DefaultConnection": "Your SQL Server or SQLite connection string here"
}

---

### 📁 4. Install Dependencies

dotnet restore

---

### 📁 5. Apply Migrations and Create the Database

dotnet ef migrations add InitialCreate
dotnet ef database update

---

### 📁 6. Run the Application

dotnet run
and
**right click** https://localhost:5001/swagger


