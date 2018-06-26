using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewNew.Models;

namespace NewNew.Pages.FormSubmissions
{
    public class IndexModel : PageModel
    {
        private readonly NewNew.Models.NewNewContext _context;

        public IndexModel(NewNew.Models.NewNewContext context)
        {
            _context = context;
        }

        public IList<FormSubmission> FormSubmission { get;set; }
        public SelectList DriverDesignations { get; set; }
        public string FormSubmissionDriverDesignation { get; set; }

        public async Task OnGetAsync(string formsubmissiondriverDesignation, string searchString)
        {
            // Use LINQ to get list of driver designations
            IQueryable<string> driverdesignationQuery = from m in _context.FormSubmission
                                                        orderby m.DriverDesignation
                                                        select m.DriverDesignation;

            var formsubmissions = from m in _context.FormSubmission
                                  select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                formsubmissions = formsubmissions.Where(s => s.LastName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(formsubmissiondriverDesignation))
            {
                formsubmissions = formsubmissions.Where(x => x.DriverDesignation == formsubmissiondriverDesignation);
            }
            DriverDesignations = new SelectList(await driverdesignationQuery.Distinct().ToListAsync());
            FormSubmission = await formsubmissions.ToListAsync();
        }
    }
}
