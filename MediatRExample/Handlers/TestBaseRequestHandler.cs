namespace MediatRExample.Handlers;

public class TestBaseRequestHandler : IRequestHandler<TestBaseRequest, bool>
{
    public Task<bool> Handle(TestBaseRequest request, CancellationToken cancellationToken)
    {
        throw new TestException("test base request threw an exception");
    }
}
