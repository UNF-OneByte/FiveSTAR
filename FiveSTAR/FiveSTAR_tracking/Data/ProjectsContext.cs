using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FiveSTAR_tracking.Models
{
    public class ProjectsContext : DbContext
    {
        public ProjectsContext (DbContextOptions<ProjectsContext> options)
            : base(options)
        {
        }

        public DbSet<FiveSTAR_tracking.Models.Projects> Projects { get; set; }
    }
}
