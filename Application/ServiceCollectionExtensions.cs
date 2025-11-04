namespace Application;

using System.ComponentModel.Design;
using Application.Features.Commands.CreateNote;
using Application.Features.Queries;
using Application.Mediator;
using Microsoft.Extensions.DependencyInjection;
using Domain.Entities;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<CreateNoteCommand, Guid>, CreateNoteCommandHandler>();
        services.AddScoped<IRequestHandler<GetAllNotesQuery, IEnumerable<Note>>, GetAllNotesQueryHandler>();
        services.AddScoped<IMediator, NotesMediator>();

        return services;
    }
}
