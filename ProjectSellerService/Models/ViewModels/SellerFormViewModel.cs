using System.Collections.Generic;

namespace ProjectSellerService.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public required Seller Seller { get; set; }
        public required ICollection<Department> Departments { get; set; }
    }
}
