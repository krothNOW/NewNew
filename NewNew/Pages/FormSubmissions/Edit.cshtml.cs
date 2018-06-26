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
    public class EditModel : PageModel
    {
        private readonly NewNew.Models.NewNewContext _context;

        public EditModel(NewNew.Models.NewNewContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FormSubmission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormSubmissionExists(FormSubmission.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FormSubmissionExists(int id)
        {
            return _context.FormSubmission.Any(e => e.ID == id);
        }
    }
}
