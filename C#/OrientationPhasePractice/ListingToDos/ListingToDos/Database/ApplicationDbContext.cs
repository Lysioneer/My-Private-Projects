using ListingToDos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListingToDos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .HasOne<Assignee>(c => c.Assignee)
                .WithMany(p => p.AssigneesToDos)
                .HasForeignKey(f => f.AssigneeId)
                .IsRequired(false);
        }
    }
}
