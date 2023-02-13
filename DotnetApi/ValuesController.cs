using Microsoft.AspNetCore.Mvc;

namespace DotnetApi;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("foo")]
    public ActionResult<string> Get(int id)
    {
        return "value";
    }
}