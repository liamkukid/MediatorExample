namespace MediatorExample;

public delegate void MessageReceivedEventHandler(string message, string sender);

public class Mediator
{
    public event MessageReceivedEventHandler MessageReceived;

    public void Send(string message, string sender)
    {
        Console.WriteLine("Sending '{0}' from {1}", message, sender);
        MessageReceived?.Invoke(message, sender);
    }

    internal IComponent Component1 { get; set; }
    internal IComponent Component2 { get; set; }

    internal void ChangeState(object state)
    {
        this.Component1.SetState(state);
        this.Component2.SetState(state);
    }
}