# WebApiProducts

ASP .NET CORE 5 API

## Instalation

1. In appsettings.json there is ConnectionStrings defaultConnection

### "defaultConnection": "Server=(localDB)\\MSSQLLocalDb;Initial Catalog=Products;Integrated Security=True"

2. In Nutget Package Console execute Update-Database command

3. Compile project and open with default browser

4. In production environment appsettings.json and appsettings.Development.json must be in .gitignore

## Methods

2 methods:

1. Get api/Products

2. Post api/Products. This method will receive a Product model