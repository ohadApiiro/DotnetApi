using Microsoft.AspNetCore.Mvc;

namespace DotnetApi;

[Route("api/messages")]
public class ValuesController : Controller
{
    //[HttpPost("v2/sendTriggerMessage")]
    [HttpPost("sendTriggerMessage")]
    public async Task<IActionResult> SendTriggerMessageAsync([FromBody] string message)
    {
        return Ok("ok");
    }
}