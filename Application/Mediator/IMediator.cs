
namespace Application.Mediator
{
    public interface IMediator
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }

    public interface IRequest<TResponse> { }
}
