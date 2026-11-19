# JobTrack

A full-stack learning project for managing job applications and tracking their status.

## Planned MVP

- Add a job application.
- View all applications or an individual application.
- Edit application details and status (Applied, Screening, Interview, Rejected, Offered).
- Delete an application.

These features are not implemented yet. Interview scheduling and authentication are
outside the initial MVP.

## Technologies

- Current backend: C#, ASP.NET Core Web API, .NET 10, OpenAPI, and
  Entity Framework Core's SQL Server provider.
- Database target: SQL Server.
- Planned frontend: React, TypeScript, and Vite.

## Current Status

The controller-based API scaffold and its generated sample endpoint have been
verified. The application entity, database context, status check constraint
configuration, and dependency injection registration have been added.

The latest EF Core changes have not yet been built or tested against SQL Server.
Migrations and JobTrack CRUD endpoints have not been added. There is no frontend.

See [PROJECT_PROGRESS.md](PROJECT_PROGRESS.md) for the development checkpoint.

## Running the Backend

Prerequisite: .NET 10 SDK.

The Development configuration targets a local default SQL Server instance using
Windows Authentication and a database named `JobTrack`. No credentials are stored
in the connection string. Migrations have not yet been added; database schema
setup instructions will follow when they are generated and reviewed.

From the repository root:

```powershell
dotnet run --project backend\JobTrack.Api --launch-profile http
```

Open the address printed in the terminal with `/api/weatherforecast` appended.
The current HTTP launch profile uses `http://localhost:5226`.

The sample endpoint returns generated JSON; it does not use a database.
Successfully calling it does not verify the configured EF Core connection.
In Development, the OpenAPI document is available at `/openapi/v1.json`.
Swagger UI has not been added.

The local connection uses `TrustServerCertificate=True` for development only.
Production connections must validate a properly trusted server certificate.

Use `Ctrl+C` in the running terminal to stop the API.

## Project Structure

- `JobTrack.slnx`: .NET solution.
- `backend/JobTrack.Api/`: ASP.NET Core Web API project.
- `.gitignore`: exclusions for generated files and local development artifacts.

Never commit credentials or connection strings containing secrets.
