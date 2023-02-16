namespace MediatRExample.PipelineBehavior;

public class GenericPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Debug.WriteLine(" --- Handling Request");
        var response = await next();
        Debug.WriteLine(" --- Finished Request");
        return response;
    }
}