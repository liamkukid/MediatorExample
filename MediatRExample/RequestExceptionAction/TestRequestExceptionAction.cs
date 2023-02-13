using MediatR.Pipeline;

namespace MediatRExample.RequestExceptionAction;

public class TestRequestExceptionAction : RequestExceptionAction<TestBaseRequest>
{
    protected override void Execute(TestBaseRequest request, Exception exception)
    {
        Debug.WriteLine($"Test request exception action works: {exception.Message}");
    }
}
