using MediatR;

namespace MediatRExample
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        public Task<bool> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
