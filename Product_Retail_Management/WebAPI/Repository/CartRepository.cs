using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ProductRetailManagementDBContext context;
        public CartRepository(ProductRetailManagementDBContext _context)
        {
            context = _context;
        }
        public async Task<Carts> AddToCart(Carts cart)
        {
            await context.Carts.AddAsync(cart);
            context.SaveChanges();
            return cart;
        }


        public Task DeleteFromCart(Carts cart)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<Carts>> GetAllCartItems()
        {
            return await context.Carts.ToListAsync();
        }
    }
}
