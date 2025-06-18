# ShipIt Inventory Management

## Setup Instructions
Open the project in VSCode. This project is in C#.

Install the following:

- Psql 
- PgAdmin - to interact with the PostgreSQL database
- Postman - to interact with the endpoints 

Run 'dotnet restore' to locate the .csproj file in the current directory and restore all necessary dependencies and tools specified in those files.

### Setting up the Database.
Ask project leader for database dump and add to project.
To create a database:  
Run ./psql -U <username of a super user> -d <database name> -f <path of the database dump file>
    *If you got a 'permission denied' error, please check you have used the super user username and not regular username.*
Repeat the ./psql command twice, once for the main programme and once for test, changing the name of the database each time e.g ShipIt and ShipItTest.

Then for each of the projects, add a `.env` file at the root of the project.
That file should contain a property named `POSTGRES_CONNECTION_STRING`.
It should look something like this:
```
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_pgAdmin_database_name;User Id=your_superuser_pgAdmin_username; Password=your_superuser_pgAdmin_password;
```

## Running The API
Once set up, simply run 'dotnet run' in the ShipIt directory.

## Running The Tests
To run the tests you should be able to run 'dotnet test' in the ShipItTests directory.

## Deploying to Production
TODO
