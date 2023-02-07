using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MediatRExample.Controllers
{
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
        public async Task<ActionResult> CreateOrder(OrderDTO order)
        {
            var command = new CreateOrderCommand(order.Id, order.Name, order.Description);
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
}
