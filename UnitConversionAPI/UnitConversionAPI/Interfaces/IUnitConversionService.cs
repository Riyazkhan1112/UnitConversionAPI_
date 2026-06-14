using UnitConversionAPI.Models;

namespace UnitConversionAPI.Interfaces;

public interface IUnitConversionService
{
    ConvertResponse Convert(ConvertRequest request);
}