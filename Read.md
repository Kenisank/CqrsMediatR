### Setup Process

## 1

Open Visual Studio Code

## 2

Navigate to the folder/Directory you want to create your project

## 3

Run "dotnet new webapi --name CqrsMediatR" in the terminal to create an empty .Net Core Api Project

## 4

Run "dotnet add package MediatR" in terminal to install MediatR Package

## 5

Register the package in services by adding "builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
" in your Program.cs
