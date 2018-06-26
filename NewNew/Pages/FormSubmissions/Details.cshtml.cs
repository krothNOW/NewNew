using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewNew.Models;

namespace NewNew.Pages.FormSubmissions
{
    public class DetailsModel : PageModel
    {
        private readonly NewNew.Models.NewNewContext _context;

        public DetailsModel(NewNew.Models.NewNewContext context)
        {
            _context = context;
        }

        public FormSubmission FormSubmission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FormSubmission = await _context.FormSubmission.FirstOrDefaultAsync(m => m.ID == id);

            if (FormSubmission == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
