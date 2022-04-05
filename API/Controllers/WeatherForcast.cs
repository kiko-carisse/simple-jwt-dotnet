using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherForcast : Controller
{
    [Authorize(Roles = "Admin")]
    [HttpPost("get-forecast")]
    public async Task<IActionResult> GetForcast()
    {
        return Ok(new {
            Category = "Storms",
            DangerLevel = "Disaster"
        });
    }
}