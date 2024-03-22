using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSellerService.Models;

namespace ProjectSellerService.Data
{
    public class ProjectSellerServiceContext : DbContext
    {
        public ProjectSellerServiceContext(DbContextOptions<ProjectSellerServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
    }
}
