using Microsoft.AspNetCore.Mvc;
using Application.Features.Commands;
using Application.Mediator;
using Application.Features.Commands.CreateNote;
using Domain.Entities;
using Application.Features.Queries;
namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNoteCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }
        [HttpGet]
        public async Task<IEnumerable<Note>> GetAll()
        {
            return await _mediator.Send(new GetAllNotesQuery());
        }
    }
}
