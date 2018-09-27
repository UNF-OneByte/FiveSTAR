using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectsContext _context;

        public CreateModel(FiveSTAR_tracking.Models.ProjectsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Projects Projects { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Projects.Add(Projects);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}