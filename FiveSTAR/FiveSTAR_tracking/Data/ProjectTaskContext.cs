using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FiveSTAR_tracking.Models
{
    public class ProjectTaskContext : DbContext
    {
        public ProjectTaskContext (DbContextOptions<ProjectTaskContext> options)
            : base(options)
        {
        }

        public DbSet<FiveSTAR_tracking.Models.ProjectTask> ProjectTasks{ get; set; }
        public DbSet<FiveSTAR_tracking.Models.ProjectsFiveStar> ProjectFiveStar { get; set; }
    }
}
