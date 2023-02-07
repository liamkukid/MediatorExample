namespace MediatorExample;

public class Person
{
    private Mediator _mediator;

    public string Name { get; set; }

    public Person(Mediator mediator, string name)
    {
        Name = name;
        _mediator = mediator;
        _mediator.MessageReceived += new MessageReceivedEventHandler(Receive);
    }

    private void Receive(string message, string sender)
    {
        if (sender != Name)
            Console.WriteLine("{0} received '{1}' from {2}", Name, message, sender);
    }

    public void Send(string message)
    {
        _mediator.Send(message, Name);
    }
}
