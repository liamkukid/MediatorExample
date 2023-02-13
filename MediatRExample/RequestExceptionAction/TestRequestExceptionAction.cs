using MediatR.Pipeline;

namespace MediatRExample.RequestExceptionAction;

public class TestRequestExceptionAction : IRequestExceptionAction<TestBaseRequest, TestException>
{
    public async Task Execute(TestBaseRequest request, TestException exception, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Test request exception action works: {exception.Message}");
    }
}
