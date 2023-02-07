namespace MediatRExample.Handlers;

public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, bool>
{
    public Task<bool> Handle(CreateOrderRequest command, CancellationToken cancellationToken)
    {
        return Task.FromResult(true);
    }
}
