using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectTasks
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
        public ProjectTask ProjectTask { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProjectTasks.Add(ProjectTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}