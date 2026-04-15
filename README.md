# Student Management API

## Features
- CRUD operations
- JWT Authentication
- Global Exception Handling
- Serilog Logging
- Swagger Documentation

## Setup
1. Clone repo
2. Update connection string
3. Run:
   dotnet ef database update
4. Run project:
   dotnet run

## API Endpoints
- POST /api/auth/login
- GET /api/student
- POST /api/student
- PUT /api/student
- DELETE /api/student/{id}
