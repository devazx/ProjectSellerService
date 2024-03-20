using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSellerService.Models
{
    public class ProjectSellerServiceContext : DbContext
    {
        public ProjectSellerServiceContext (DbContextOptions<ProjectSellerServiceContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSellerService.Models.Department> Department { get; set; } = default!;
    }
}
