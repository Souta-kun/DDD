using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Panaderia.ApplicationCore.DTOs;
using Panaderia.ApplicationCore.Services.Pan;

namespace Panaderia.WebApi.Controllers;

[ApiController]
[EnableCors("CorsApp")]
[Route("api/[controller]")]
public class PanController : ControllerBase
{
    public IPanService panService { get; set; }
    
    public PanController(IPanService panService)
    {
        this.panService = panService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = panService.Read();
        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var result = panService.Read(id);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Post([FromBody] PanDto request)
    {
        panService.Create(request);
        return Ok();
    }
}
