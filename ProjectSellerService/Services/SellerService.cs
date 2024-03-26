﻿using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectSellerService.Data;
using ProjectSellerService.Models;

namespace ProjectSellerService.Services
{
    public class SellerService 
    {
        private readonly ProjectSellerServiceContext _context;

        public SellerService(ProjectSellerServiceContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
