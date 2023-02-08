namespace MediatRExample.ExceptionHandler;

public class GlobalExceptionHandler : IRequestExceptionHandler<TestRequest, bool>
{
    public async Task Handle(TestRequest request, Exception exception, 
        RequestExceptionHandlerState<bool> state, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Global exception handle. Message: {exception.Message}");
        state.SetHandled(true);
    }
}
