using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Panaderia.ApplicationCore.Services.Proveedor;

namespace Panaderia.WebApi.Controllers;

[ApiController]
[EnableCors("CorsApp")]
[Route("api/[controller]")]
public class ProveedorController : ControllerBase
{
    public IProveedorService proveedorService { get; set; }
    
    public ProveedorController(IProveedorService proveedorService)
    {
        this.proveedorService = proveedorService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = proveedorService.Read();
        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var result = proveedorService.Read(id);
        return Ok(result);
    }
}
