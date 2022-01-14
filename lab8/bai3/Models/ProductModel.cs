using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Models
{
    public class ProductModel
    {
        private ProductContext _context; 
        public ProductModel(ProductContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> FindAll()
        {
            return await _context.products.ToListAsync();
        }
        public async Task<Product> Find(int id)
        {
            return await _context.products.FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}
