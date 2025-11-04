using Microsoft.EntityFrameworkCore;
using Domain.Entities;

using Application.Notes.Repositories;

namespace Infrastructure.Persistance
{
    public class NoteRepository(AppDbContext context): INoteRepository 
    {
        private readonly AppDbContext _context = context;

        public async Task AddAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note?> GetByIdAsync(Guid id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task UpdateAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }
    }
}
