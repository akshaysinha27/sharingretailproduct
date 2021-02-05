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


       


        public async Task<IEnumerable<Carts>> GetAllCartItems()
        {
            return await context.Carts.ToListAsync();
        }

        public async Task<Carts> DecreaseQuantity(int id)
        {
            Carts cart = await context.Carts.FindAsync(id);
            cart.Quantity--;
            context.Carts.Update(cart);
            await context.SaveChangesAsync();
            return cart;
        }



        public async Task<bool> DeleteAllCartItems()
        {
            context.Carts.RemoveRange(context.Carts);
            await context.SaveChangesAsync();
            return true;
        }



        public async Task<Carts> DeleteFromCart(int id)
        {
            Carts cart = await context.Carts.FindAsync(id);
            context.Carts.Remove(cart);
            await context.SaveChangesAsync();
            return cart;
        }
        public async Task<Carts> IncreaseQuantity(int id)
        {
            Carts cart = await context.Carts.FindAsync(id);
            cart.Quantity++;
            context.Carts.Update(cart);
            await context.SaveChangesAsync();
            return cart;
        }
    }
}
