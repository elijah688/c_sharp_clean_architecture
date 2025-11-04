using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Entities;

namespace Infrastructure.Persistance
{   
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Title).IsRequired().HasMaxLength(200);
                entity.Property(n => n.Content).IsRequired();
                entity.Property(n => n.CreatedAt).IsRequired();
            });
        }
    }
}
