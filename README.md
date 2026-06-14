# Unit Conversion API

## Overview

This project is an ASP.NET Core Web API that converts values between different units of measurement.

Supported conversion categories:

* Length
* Temperature
* Weight

## Technologies Used

* ASP.NET Core Web API
* C#
* Swagger

## Running the Project

### Prerequisites

* .NET 10 SDK
* Visual Studio 2022

### Steps

1. Clone the repository

```bash
git clone [<repository-url>](https://github.com/Riyazkhan1112/UnitConversionAPI_.git)
```

2. Navigate to the project folder

```bash
cd UnitConversionAPI
```

3. Restore packages

```bash
dotnet restore
```

4. Run the application

```bash
dotnet run
```

## Swagger Documentation

After running the application, open the following URL in your browser:

```text
https://localhost:<port>/swagger
```

Example:

```text
https://localhost:7031/swagger
```

## API Endpoint

### Convert Units

**POST** `/api/conversion`

### Sample Request

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

### Sample Response

```json
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 32.8084
}
```

## Future Improvements

* Add more unit categories
* Store conversion data in a database
* Add unit tests
* Add API versioning

## Author

Riyazkhan Pathan
