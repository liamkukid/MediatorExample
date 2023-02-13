namespace MediatRExample.RequestExceptionAction;

public class TestSourceRequestExceptionAction : IRequestExceptionAction<TestSourceRequest, TestException>
{
    public async Task Execute(TestSourceRequest request, TestException exception, CancellationToken cancellationToken)
    {
        Debug.WriteLine($" --- Test base request exception action works: {exception.Message}");
    }
}
