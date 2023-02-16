namespace MediatRExample.PipelineBehavior;

public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{

    public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        Debug.WriteLine("- All Done");
    }
}
