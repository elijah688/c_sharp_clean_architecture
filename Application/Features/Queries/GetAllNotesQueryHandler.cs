using Application.Mediator;
using Application.Notes.Repositories;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Features.Queries
{
    public class GetAllNotesQueryHandler(INoteRepository repository) : IRequestHandler<GetAllNotesQuery, IEnumerable<Note>>
    {
        private readonly INoteRepository _repository = repository;

        public async Task<IEnumerable<Note>> Handle(GetAllNotesQuery request)
        {
            return await _repository.GetAllAsync();
        }
    }
}
