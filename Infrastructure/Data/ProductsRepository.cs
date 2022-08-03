using Core.Entities;
using Core.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProductsRepository : IProductRepository
{
    private readonly StoreContext _context;

    public ProductsRepository(StoreContext context)
    {
        _context = context;
    }


    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
}