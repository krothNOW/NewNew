using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewNew.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NewNewContext(
                serviceProvider.GetRequiredService<DbContextOptions<NewNewContext>>()))
            {
                // Look for any FormSubmissions.
                if (context.FormSubmission.Any())
                {
                    return;  // DB has been seeded
                }
                context.FormSubmission.AddRange(
                    new FormSubmission
                    {
                        FirstName = "Kevin",
                        LastName = "Roth",
                        DriverEmail = "kroth@nowcourier.com",
                        DriverID = 2318,
                        DriverDesignation = "Indy Routes",
                        BeginDate = DateTime.Parse("2018-06-28"),
                        EndDate = DateTime.Parse("2018-06-30"),
                        AdditionalDetails = "nope",
                        BeginDuration = "Afternoon"
                    },

                    new FormSubmission
                    {
                        FirstName = "Kevin",
                        LastName = "Gmail",
                        DriverEmail = "kmroth17@gmail.com",
                        DriverID = 1710,
                        DriverDesignation = "Office Depot Routes",
                        BeginDate = DateTime.Parse("2018-06-28"),
                        EndDate = DateTime.Parse("2018-06-29"),
                        AdditionalDetails = "OD331",
                        BeginDuration = "All Day"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
