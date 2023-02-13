namespace MediatRExample.Handlers;

public class TestSourceRequestHandler : IRequestHandler<TestSourceRequest, bool>
{
    public Task<bool> Handle(TestSourceRequest request, CancellationToken cancellationToken)
    {
        throw new TestException("test base request threw an exception");
    }
}
