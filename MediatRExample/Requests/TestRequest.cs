namespace MediatRExample.Requests;

public class TestRequest : IRequest<bool>
{
    public TestRequest()
    {
        CallException = false;
    }

    public TestRequest(bool callException)
    {
        CallException = callException;
    }

    public bool CallException { get; }
}
