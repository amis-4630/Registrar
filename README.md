# Registrar  

## What is Registrar?

This is a sample applicaiton that demonstrates APIs and Data Access in .NET 7.

## Steps to Create the Model

1. Create a new ASP.NET 7 Web Application `dotnet new webapi -n Registrar`
1. Build and run the application `dotnet run`
1. Add a new class `Student` to the `Models` folder
1. Generate the `Address` class using "light bulb" in VS Code
1. Add a new class `Course` to the `Models` folder
1. Add a new class `Enrollment` to the `Models` folder

## Steps to Create the Controller

1. Add a new class `StudentsController` to the `Controllers` folder
1. Add a new class `RegistrarContext` to the `Models` folder
1. Add the `DbSet` properties to the `RegistrarContext` class
1. Add scaffolding global tools
    - `dotnet tool install -g dotnet-aspnet-codegenerator`
    - `dotnet tool install -g dotnet-ef`
1. Add scaffoling tools to the project
    - `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`
    - `dotnet add package Microsoft.EntityFrameworkCore.Design`
    - `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
    - `dotnet add package Microsoft.EntityFrameworkCore.Tools`
1. Generate the Courses controller
    - `dotnet aspnet-codegenerator controller -name CoursesController -api -m Courses -dc RegistrarContext -outDir Controllers`
1. Generate the Enrollments controller
    - `dotnet aspnet-codegenerator controller -name EnrollmentsController -api -m Enrollments -dc RegistrarContext -outDir Controllers`
