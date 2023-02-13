namespace MediatRExample.RequestExceptionAction;

public class TestRequestExceptionAction : IRequestExceptionAction<TestRequest, TestException>
{
    public async Task Execute(TestRequest request, TestException exception, CancellationToken cancellationToken)
    {
        Debug.WriteLine($" --- Test request exception action works: {exception.Message}");
    }
}
