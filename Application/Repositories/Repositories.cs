using Domain.Entities;

namespace Application.Notes.Repositories
{
    public interface INoteRepository
    {
        Task<Note> GetByIdAsync(Guid id);
        Task<IEnumerable<Note>> GetAllAsync();
        Task AddAsync(Note note);
        Task UpdateAsync(Note note);
        Task DeleteAsync(Guid id);
    }
}
