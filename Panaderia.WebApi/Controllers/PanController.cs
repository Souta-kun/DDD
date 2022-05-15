using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Panaderia.ApplicationCore.Services;

namespace Panaderia.WebApi.Controllers;

[ApiController]
[EnableCors("CorsApp")]
[Route("api/[controller]")]
public class PanController : ControllerBase
{
    public IPanService PanService { get; set; }
    
    public PanController(IPanService panService)
    {
        this.PanService = panService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = PanService.Read();
        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var result = PanService.Read(id);
        return Ok(result);
    }
}
