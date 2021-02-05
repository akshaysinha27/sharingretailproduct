using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class WishListRepository : IWishListRepository
    {
        private readonly ProductRetailManagementDBContext context;
        public WishListRepository(ProductRetailManagementDBContext _context)
        {
            context = _context;
        }
        public async Task<WishLists> AddToWishlist(WishLists item)
        {
            await context.WishLists.AddAsync(item);
            context.SaveChanges();
            return item;
        }

        public async Task<WishLists> DeleteFromWishlist(int id)
        {
            WishLists wishlist = await context.WishLists.FindAsync(id);
            context.WishLists.Remove(wishlist);
            await context.SaveChangesAsync();
            return wishlist;
        }



        public async Task<WishLists> DecreaseQuantity(int id)
        {
            WishLists wishlist = await context.WishLists.FindAsync(id);
            wishlist.Quantity--;
            context.WishLists.Update(wishlist);
            await context.SaveChangesAsync();
            return wishlist;
        }



        public async Task<IEnumerable<WishLists>> GetAllWishlistItems()
        {
            return await context.WishLists.ToListAsync();
        }
    }
}
