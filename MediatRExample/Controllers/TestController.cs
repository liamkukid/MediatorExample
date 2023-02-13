namespace MediatRExample.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IMediator mediator;

    public TestController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost]
    [Route("request")]
    public async Task<ActionResult> TestRequest()
    {
        var command = new TestRequest();
        var response = await mediator.Send(command);
        Debug.WriteLine(response);
        return Ok(response);
    }

    [HttpPost]
    [Route("stream")]
    public async Task<ActionResult> TestStream()
    {
        var command = new TestStreamRequest();
        var result = new List<string>();
        await foreach(var line in mediator.CreateStream(command))
        {
            result.Add(line);
            Debug.WriteLine(line);
        }
        return Ok(string.Join("\t\n", result));
    }

    [HttpPost]
    [Route("notification")]
    public async Task<ActionResult> TestNotification()
    {
        var command = new TestNotificationRequest();
        await mediator.Publish(command);
        return Ok(true);
    }

    [HttpPost]
    [Route("exception")]
    public async Task<ActionResult> TestExeption()
    {
        var command = new TestRequest(true);
        var response = await mediator.Send(command);
        Debug.WriteLine(response);
        return Ok(response);
    }

    [HttpPost]
    [Route("exception_action")]
    public async Task<ActionResult> TestExceptionAction()
    {
        var command = new TestSourceRequest();
        var response = await mediator.Send(command);
        Debug.WriteLine(response);
        return Ok(response);
    }
}
