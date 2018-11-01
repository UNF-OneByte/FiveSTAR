using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectFiveStar
{
    public class CreateModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public CreateModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProjectsFiveStar ProjectsFiveStar { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProjectFiveStar.Add(ProjectsFiveStar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}