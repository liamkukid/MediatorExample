namespace MediatRExample.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator mediator;

    public OrdersController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult> CreateOrder()
    {
        var command = new CreateOrderRequest();
        var response = await mediator.Send(command);
        Debug.WriteLine(response);
        return Ok();
    }

    [HttpPost]
    [Route("stream")]
    public async Task<ActionResult> UseStream()
    {
        var command = new ExampleStreamRequest();
        var result = new List<string>();
        await foreach(var line in mediator.CreateStream(command))
        {
            result.Add(line);
            Debug.WriteLine(line);
        }
        return Ok(string.Join("\t\n", result));
    }
}
