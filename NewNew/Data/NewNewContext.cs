using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewNew.Models
{
    public class NewNewContext : DbContext
    {
        public NewNewContext (DbContextOptions<NewNewContext> options)
            : base(options)
        {
        }

        public DbSet<NewNew.Models.FormSubmission> FormSubmission { get; set; }
    }
}
