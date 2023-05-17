using Microsoft.AspNetCore.Mvc;

namespace DotnetApi;

[Route("api/messages")]
public class ValuesController : Controller
{
    [HttpPost("sendTriggerMessage")]
    [HttpPost("v2/sendTriggerMessage")]
    public async Task<IActionResult> SendTriggerMessageAsync([FromBody] string message)
    {
        return Ok("ok");
    }
}