using MediatR.Pipeline;

namespace MediatRExample.ExceptionHandler;

public class TestExceptionHandler : IRequestExceptionHandler<TestRequest, bool, TestException>
{
    public async Task Handle(TestRequest request, TestException exception, 
        RequestExceptionHandlerState<bool> state, CancellationToken cancellationToken)
    {
        Debug.WriteLine(exception.Message);
        state.SetHandled(true);
    }
}
