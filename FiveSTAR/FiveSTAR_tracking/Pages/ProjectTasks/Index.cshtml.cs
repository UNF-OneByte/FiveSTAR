using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectTasks
{
    public class IndexModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public IndexModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
        {
            _context = context;
        }

        public IList<ProjectTask> ProjectTask { get;set; }

        public async Task OnGetAsync()
        {
            ProjectTask = await _context.ProjectTasks.ToListAsync();
        }
    }
}
