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
    public class DeleteModel : PageModel
    {
        private readonly NewNew.Models.NewNewContext _context;

        public DeleteModel(NewNew.Models.NewNewContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FormSubmission = await _context.FormSubmission.FindAsync(id);

            if (FormSubmission != null)
            {
                _context.FormSubmission.Remove(FormSubmission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
