using Microsoft.AspNetCore.Mvc;

namespace ProjectX.WebAPI.Controllers;
public class HealthController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("Status")]
    public OkResult Status()
    {
        return Ok();
    }
}
