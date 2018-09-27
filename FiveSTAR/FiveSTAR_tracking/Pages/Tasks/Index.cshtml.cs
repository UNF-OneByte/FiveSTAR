using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectsContext _context;

        public IndexModel(FiveSTAR_tracking.Models.ProjectsContext context)
        {
            _context = context;
        }

        public IList<Projects> Projects { get;set; }

        public async Task OnGetAsync()
        {
            Projects = await _context.Projects.ToListAsync();
        }
    }
}
