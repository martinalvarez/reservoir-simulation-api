# Reservoir API - Backend (.NET 8)

This is the core engine of the simulation system.

## Project Structure
- **Controllers**: Handles REST endpoints.
- **Dependency Injection**: Services are registered in `Program.cs`.
- **CORS**: Configured for secure communication with the React frontend.

## Key Concepts Applied
- **Repository Pattern**: Abstracting data access from the business logic.
- **Service Layer**: Decoupling calculations from the API controllers.
- **JSON Serialization**: Using `System.Text.Json` for high-performance parsing.

## How to run
`dotnet run`