using UnitConversionAPI.Interfaces;
using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services;

public class UnitConversionService : IUnitConversionService
{
    public ConvertResponse Convert(ConvertRequest request)
    {
        double result = request.Category.ToLower() switch
        {
            "length" => ConvertLength(
                request.Value,
                request.FromUnit,
                request.ToUnit),

            "temperature" => ConvertTemperature(
                request.Value,
                request.FromUnit,
                request.ToUnit),

            "weight" => ConvertWeight(
                request.Value,
                request.FromUnit,
                request.ToUnit),

            _ => throw new Exception("Unsupported category")
        };

        return new ConvertResponse
        {
            OriginalValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        };
    }

    private double ConvertLength(double value, string from, string to)
    {
        if (from == "meter" && to == "feet")
            return value * 3.28084;

        if (from == "feet" && to == "meter")
            return value / 3.28084;

        throw new Exception("Invalid length conversion");
    }

    private double ConvertWeight(double value, string from, string to)
    {
        if (from == "kg" && to == "pound")
            return value * 2.20462;

        if (from == "pound" && to == "kg")
            return value / 2.20462;

        throw new Exception("Invalid weight conversion");
    }

    private double ConvertTemperature(double value, string from, string to)
    {
        if (from == "celsius" && to == "fahrenheit")
            return (value * 9 / 5) + 32;

        if (from == "fahrenheit" && to == "celsius")
            return (value - 32) * 5 / 9;

        throw new Exception("Invalid temperature conversion");
    }
}