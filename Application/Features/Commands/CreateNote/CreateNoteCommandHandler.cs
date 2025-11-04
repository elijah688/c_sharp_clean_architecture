using Application.Mediator;
using Application.Notes.Repositories;
using Domain.Entities;
using Application.Features.Commands;
using Application.Features.Commands.CreateNote;

namespace Application.Features.Commands.CreateNote
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Guid>
    {
        private readonly INoteRepository _repository;

        public CreateNoteCommandHandler(INoteRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateNoteCommand request)
        {
            var note = new Note(
                    request.Title,
                    request.Content
            );
          
            await _repository.AddAsync(note);
            return note.Id;
        }
    }
}
