# Clean Architecture starting point

## About the project
A starting point for Clean Architecture with ASP.NET Core. This is basic example of how to start clean architecture in a web api c# project.

## Technologies

This API was developed using the following technologies:

* Microsoft .NET Core 8
* EF Core In-Memory Database Provider: [EF Core In-Memory](https://learn.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=dotnet-core-cli)

## Getting Started

First install o [.Net Core 8.0 SDK](https://www.microsoft.com/net/download/core), then use the following commands in then terminal to clone and execute the project:

```
git clone https://github.com/nellsonteixeira/CleanArch
cd CleanArch\CleanArch.Api\
dotnet build
dotnet run
```
At this moment, the startup configurations will be displayed in the terminal, as well as the address and port where the application is running. Simply copy the URL and access its endpoints as shown below, always respecting the port where the application is running.

> You can also open the Solution file directly in Visual Studio, set the project CleanArch.Api.csproj as default, and press the F5 key to run the application.

## documentation

This project includes documentation for the API endpoints created using [Swagger](https://swagger.io/).
After running the application, simply access the URL  "http://localhost:{port}/docs/", where {port} should be replaced by the port on which the application is running on your computer.

## Learn More

- [The Clean Architecture - Robert C. Martin (Uncle Bob)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [Onion Architecture in ASP.NET Core](https://code-maze.com/onion-architecture-in-aspnetcore/)
- [Aprendendo a Arquitetura Cebola em .Net 5](https://medium.com/xp-inc/apreendendo-a-arquitetura-cebola-em-net-5-d2e06dcc9e8)
