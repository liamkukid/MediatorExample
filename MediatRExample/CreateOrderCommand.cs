using MediatR;

namespace MediatRExample
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public CreateOrderCommand(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}
