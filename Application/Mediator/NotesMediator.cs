namespace Application.Mediator;

public class NotesMediator(IServiceProvider provider) : IMediator
{
    private readonly IServiceProvider _provider = provider;

    public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
    {
        var handlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(request.GetType(), typeof(TResponse));
        var handler = _provider.GetService(handlerType) ?? throw new Exception($"No handler registered for {request.GetType().Name}");
        var method = handlerType.GetMethod("Handle")!;

        return await (Task<TResponse>)method.Invoke(handler, [request])!;

    }
}
