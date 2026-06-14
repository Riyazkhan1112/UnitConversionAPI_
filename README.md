
# Unit Conversion API

## Overview

Unit Conversion API is an ASP.NET Core Web API that allows users to convert values between different units of measurement.

Currently supported conversion categories:

* Length
* Temperature
* Weight / Mass

The application is designed using a layered architecture and follows clean coding practices to support future scalability and maintainability.

---

## Technologies Used

* ASP.NET Core 8 Web API
* C#
* Swagger / OpenAPI
* Dependency Injection
* xUnit (Unit Testing)

---

## Project Structure

```text
UnitConversionAPI
│
├── Controllers
├── Interfaces
├── Models
├── Services
├── Middleware
├── Tests
├── Program.cs
└── README.md
```

---

## Supported Conversions

### Length

* Meter → Feet
* Feet → Meter

### Temperature

* Celsius → Fahrenheit
* Fahrenheit → Celsius

### Weight

* Kilogram → Pound
* Pound → Kilogram

---

## API Endpoint

### Convert Units

```http
POST /api/conversion
```

### Request

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

### Response

```json
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 32.8084
}
```

---

## Prerequisites

Before running the project, ensure the following software is installed:

* .NET 8 SDK
* Visual Studio 2022

---

## Running the Application

### Clone Repository

```bash
git clone https://github.com/<your-username>/UnitConversionAPI.git
```

### Navigate to Project

```bash
cd UnitConversionAPI
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Project

```bash
dotnet run
```

---

## Swagger Documentation

After running the application, open:

```text
https://localhost:<port>/swagger
```

Example:

```text
https://localhost:7031/swagger
```

Swagger UI provides interactive API testing and documentation.

---

## Design Decisions

### Service Layer

Business logic is separated from controllers using a service layer.

Benefits:

* Better maintainability
* Easier unit testing
* Follows Separation of Concerns

### Dependency Injection

Services are registered using ASP.NET Core Dependency Injection container.

Benefits:

* Loose coupling
* Easier testing
* Improved scalability

### Future Enhancements

The current implementation uses hardcoded conversion definitions.

Future improvements may include:

* Database-driven unit configuration
* Additional conversion categories
* Caching support
* API versioning
* Authentication and Authorization

---

## Testing

Run tests using:

```bash
dotnet test
```

---

## Author

Riyazkhan Pathan

Backend Developer
