# 🎉 Event Management Application

Welcome to the Event Management Application! This application is built with ASP.NET Core to help you manage events efficiently.

## 📋 Table of Contents

- Setting Up `appsettings.json`
- Important Note
- Running the Application
- Creating and Applying Migrations
- Troubleshooting

## 🛠️ Setting Up `appsettings.json`

Create a file named `appsettings.json` in the root directory of your project and add the following configuration:

```json
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=LTIN485218\\MSSQL;Database=EventManageCFA;Trusted_Connection=Yes;MultipleActiveResultSets=true;TrustServerCertificate=true"
    }
}

⚠️ Important Note
To ensure that your appsettings.json file, which contains sensitive information like your connection string, is not included in your Git repository, add it to your .gitignore file:

appsettings.json
appsettings.Development.json
🚀 Running the ApplicationClone the repository:

git clone <repository-url>
Navigate to the project directory:

cd EventManagementTrialCFA
Restore the dependencies:

dotnet restore
Apply the migrations to update the database:

dotnet ef database update
Run the application:

dotnet run
🛠️ Creating and Applying Migrations
Add a new migration:

dotnet ef migrations add <MigrationName>
Apply the migration to the database:

dotnet ef database update
🛠️ Troubleshooting
Database Connection Issues: Ensure that your connection string in appsettings.json is correct and that your SQL Server instance is running.
Migration Errors: If you encounter errors during migration, you may need to revert the migration and try again. Use the following commands:
dotnet ef migrations remove
dotnet ef migrations add <MigrationName>
dotnet ef database update
Feel free to reach out if you have any questions or need further assistance!

Happy coding! 🎉
