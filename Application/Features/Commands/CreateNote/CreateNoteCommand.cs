using Application.Mediator;
using Domain.Entities;

namespace Application.Features.Commands.CreateNote
{
    // Command to create a new Note
    public class CreateNoteCommand(string title, string content) : IRequest<Guid>
    {
        public string Title { get; set; } = title;
        public string Content { get; set; } = content;
    }
}
