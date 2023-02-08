namespace MediatRExample.Requests;

public class InheritedTestRequest : TestRequest
{
    public InheritedTestRequest(bool callException) : base(callException)
    {
    }
}
