namespace MediatRExample.ExceptionHandler;

public class InheritedRequestExceptionHandler : AsyncRequestExceptionHandler<TestRequest, bool>
{
    protected override async Task Handle(TestRequest request, Exception exception, 
        RequestExceptionHandlerState<bool> state, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Inherited exception handle. Message: {exception.Message}");
        state.SetHandled(true);
    }
}
