namespace MediatRExample.Handlers;

public class InheritedTestRequestHandler : IRequestHandler<InheritedTestRequest, bool>
{
    public Task<bool> Handle(InheritedTestRequest command, CancellationToken cancellationToken)
    {
        if (command.CallException)
            throw new TestException("request threw an exception");

        return Task.FromResult(true);
    }
}