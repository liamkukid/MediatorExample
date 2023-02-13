namespace MediatRExample.RequestExceptionAction;

public class TestBaseRequestExceptionAction : IRequestExceptionAction<TestBaseRequest, TestException>
{
    public async Task Execute(TestBaseRequest request, TestException exception, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Test base request exception action works: {exception.Message}");
    }
}
