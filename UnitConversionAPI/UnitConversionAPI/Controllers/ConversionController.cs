using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Interfaces;
using UnitConversionAPI.Models;

namespace UnitConversionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IUnitConversionService _service;

    public ConversionController(
        IUnitConversionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Convert(
        [FromBody] ConvertRequest request)
    {
        var result = _service.Convert(request);

        return Ok(result);
    }
}