namespace MediatRExample.Handlers;

public class TestNotificationRequestHandler_1 :
    INotificationHandler<TestNotificationRequest>
{
    public async Task Handle(TestNotificationRequest notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine("notification 1");
    }
}
