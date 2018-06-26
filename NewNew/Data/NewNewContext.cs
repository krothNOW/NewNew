using Microsoft.EntityFrameworkCore;

namespace NewNew.Models
{
    public class NewNewContext : DbContext
    {
        public NewNewContext (DbContextOptions<NewNewContext> options)
            : base(options)
        {
        }

        public DbSet<FormSubmission> FormSubmission { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
