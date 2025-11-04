using Application.Mediator;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Features.Queries
{
    public class GetAllNotesQuery : IRequest<IEnumerable<Note>>
    {
    }
}
