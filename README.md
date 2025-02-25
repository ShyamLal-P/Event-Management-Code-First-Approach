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
        "DefaultConnection": "Server=<Add Your Connection String>;Database=EventManageCFA;Trusted_Connection=Yes;MultipleActiveResultSets=true;TrustServerCertificate=true"
    }
}
```
## ⚠️ Important Note

To ensure that your `appsettings.json` file, which contains sensitive information like your connection string, is not included in your Git repository, add it to your `.gitignore` file:

appsettings.json
appsettings.Development.json
## 🚀 Running the Application

1. **Clone the repository**:
   ```sh
   git clone https://github.com/ShyamLal-P/Event-Management-Code-First-Approach
   ```
Navigate to the project directory:

```sh
cd EventManagementTrialCFA
```
Restore the dependencies:

```sh
dotnet restore
```
Apply the migrations to update the database:

```sh
dotnet ef database update
```
Run the application:

```sh
dotnet run
```
🛠️ Creating and Applying Migrations
Add a new migration:

```sh
dotnet ef migrations add <MigrationName>
```
Apply the migration to the database:

```sh
dotnet ef database update
```
## 🛠️ Troubleshooting

### Database Connection Issues
Ensure that your connection string in `appsettings.json` is correct and that your SQL Server instance is running.

### Migration Errors
If you encounter errors during migration, you may need to revert the migration and try again. Use the following commands:
```sh
dotnet ef migrations remove
```
```sh
dotnet ef migrations add <MigrationName>
```
```sh
dotnet ef database update
```
Feel free to reach out if you have any questions or need further assistance!

Happy coding! 🎉
