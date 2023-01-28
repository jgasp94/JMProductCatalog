using JMProductCatalog.Domain.Entities;
using JMProductCatalog.Domain.Interfaces;
using JMProductCatalog.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMProductCatalog.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetByIdAsync(Guid? id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(Guid? categoryId)
        {
            return await _context
                                        .Products.Include(c => c.Category)
                                        .SingleOrDefaultAsync(p => p.CategoryId == categoryId);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
