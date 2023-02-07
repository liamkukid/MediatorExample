namespace MediatRExample.Handlers;

public class TestRequestHandler : IRequestHandler<TestRequest, bool>
{
    public Task<bool> Handle(TestRequest command, CancellationToken cancellationToken)
    {
        return Task.FromResult(true);
    }
}
