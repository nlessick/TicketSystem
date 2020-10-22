using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Name>().HasData(
                new Name { NameId = "work", ActualName = "Work" },
                new Name { NameId = "home", ActualName = "Home" },
                new Name { NameId = "cell", ActualName = "Cell" }

            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = "todo", ActualName = "To Do" },
                new Status { StatusID = "inprogress", ActualName = "In Progress" },
                new Status { StatusID = "qa", ActualName = "Quality Assurance" },
                new Status { StatusID = "done", ActualName = "Done" }
            );
        }
    }
}
