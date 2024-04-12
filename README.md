RESTful API with .NET Core and SQL Server
This is a simple RESTful API built using Microsoft .NET Core and C#, with CRUD operations on a SQL Server database.

Features:
Implements CRUD (Create, Read, Update, Delete) operations for a Product entity.
Uses Entity Framework Core for database access and migrations.
Follows RESTful principles for API design.
Includes proper error handling and validation.
Provides API documentation.

Prerequisites
.NET Core SDK (version 5.0 or later)
Sql Server 2022

Getting Started:
Clone the repository
  git clone https://github.com/Authurton/CrudOperations.git

Navigate to the project directory:
  cd CrudOperations

Update the appsettings.json file with your SQL Server connection details:
  "ConnectionStrings": {
    "ProductCS": "server=YourServerName; database=YourDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;"
  },

  Create and apply the initial database migration:
    add-migration Initial then
    update-database

  Run the application:
    dotnet run or ctrl + shift + F5 or Use the Visual Studio
