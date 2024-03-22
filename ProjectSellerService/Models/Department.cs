using System.Collections.Generic;
using ProjectSellerService.Models;
using System;
using System.Linq;

namespace ProjectSellerService.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name, ICollection<Seller> sellers)
        {
            Id = id;
            Name = name;
            // não coloca o que for coleção
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers
                .Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
