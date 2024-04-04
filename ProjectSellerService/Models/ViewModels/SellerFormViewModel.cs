namespace ProjectSellerService.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public required ICollection<Department> Departments { get; set; }
    }
}
