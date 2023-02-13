namespace MediatRExample.Handlers;

public class TestNotificationRequestHandler_2 :
    INotificationHandler<TestNotificationRequest>
{
    public async Task Handle(TestNotificationRequest notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine(" --- notification 2");
    }
}
