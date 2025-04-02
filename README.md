# ChatApp Backend API

A robust real-time chat application backend built with **ASP.NET Core 8 Web API**. This API provides comprehensive user authentication, message handling, and conversation management endpoints to support modern chat application frontends.

## 🚀 Features

- **Secure Authentication**: JWT-based authentication and authorization
- **Real-time Messaging**: Instant message delivery using SignalR
- **RESTful Architecture**: Well-structured API endpoints following REST principles
- **Data Persistence**: Entity Framework Core for efficient data access and management

## 🧰 Technologies Used

- **.NET 8**: Latest ASP.NET Core Web API framework
- **Entity Framework Core**: ORM for database operations
- **SQL Server**: Primary database (with SQLite option for development)
- **JWT Authentication**: Token-based security
- **AutoMapper**: Object-to-object mapping
- **Swagger/OpenAPI**: API documentation and testing
- **SignalR**: Real-time communication

## 📦 Getting Started

Follow these steps to set up and run the API project in your local development environment.

### ✅ Prerequisites

Ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQLite for local development)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### 🔧 Installation

#### 1. Clone the Repository

```bash
git clone https://github.com/canturane/Chatapp_Backend.git
cd Chatapp_Backend
```

#### 2. Configure the Database

Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your SQL Server or SQLite connection string here"
  }
}
```

#### 3. Install Dependencies

```bash
dotnet restore
```

#### 4. Apply Migrations and Create the Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

#### 5. Run the Application

```bash
dotnet run
```

The API will be available at: `https://localhost:5001`

Access Swagger UI at: `https://localhost:5001/swagger`

