Overview
Web app template by the Microsoft Devices Software Experiences team.

Client (front-end)
React with Redux and TypeScript
Microsoft Fabric UI
NSwag generated DTOs and client for back-end API
MSAL-React
MSAL-Browser
Service (back-end)
ASP.NET Core 3.1
MediatR as CQRS implementation
AutoMapper handling Entity-to-DTO mapping
Unit and integration tests using Moq and MSTest
Swagger UI
How to run locally
Download and install the .NET Core SDK
If you don't have localdb available on your system, Download and install SQL Server Express
NOTE: We will remove the localdb requirement in a future PR
Open a terminal such as PowerShell, Command Prompt, or bash and navigate to the service folder
Run the following dotnet commands:
dotnet build
dotnet run --project Microsoft.DSX.ProjectTemplate.API
Open your browser to: https://localhost:44345/swagger.
In another terminal, navigate to the client folder and run the following npm commands:
npm install
npm start
The webpack dev server hosts the front-end and your browser will open to: http://localhost:3000
Adding an Entity Framework Core migration
Open a command prompt in the Microsoft.DSX.ProjectTemplate.Data folder.
dotnet tool install --global dotnet-ef
dotnet ef migrations add <NAME OF MIGRATION>
Removing the latest Entity Framework Core migration
Open a command prompt in the Microsoft.DSX.ProjectTemplate.Data folder.
dotnet ef migrations remove
To-Do
Migrate to MSAL.js
Include Authentication and Authorization logic
Add Docker file
Move away from localdb
Create a CLI setup wizard
Contributing
This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the Microsoft Open Source Code of Conduct. For more information see the Code of Conduct FAQ or contact opencode@microsoft.com with any additional questions or comments.
