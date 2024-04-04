using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectSellerService.Data;
using ProjectSellerService.Models;
using System.Linq;


namespace ProjectSellerService.Services
{
    public class DepartmentService
    {
        private readonly ProjectSellerServiceContext _context;

        public DepartmentService(ProjectSellerServiceContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.ToList();

        }
    }
}
