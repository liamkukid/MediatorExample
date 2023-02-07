using MediatR;

namespace MediatRExample
{
    public class ExampleStreamRequestHandler : IStreamRequestHandler<ExampleStreamRequest, string>
    {
        public async IAsyncEnumerable<string> Handle(ExampleStreamRequest request, CancellationToken cancellationToken)
        {
            var random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(400);
                yield return string.Concat(Enumerable.Range(0, 30).Select(x => random.Next(0, 9)));
            };
        }
    }
}
