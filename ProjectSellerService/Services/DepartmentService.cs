using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectSellerService.Data;
using ProjectSellerService.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ProjectSellerService.Services
{
    public class DepartmentService
    {
        private readonly ProjectSellerServiceContext _context;

        public DepartmentService(ProjectSellerServiceContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
