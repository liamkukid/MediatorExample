namespace MediatRExample.PipelineBehavior;

public class GenericRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
{
    public async Task Process(TRequest request, CancellationToken cancellationToken)
    {
        Debug.WriteLine("- Starting Up");
    }
}
