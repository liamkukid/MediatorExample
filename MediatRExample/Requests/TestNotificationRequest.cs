namespace MediatRExample.Requests;

public class TestNotificationRequest : INotification
{
    public string Message { get; set; }
}
