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



        public Task<WishLists> DeleteFromWishlist(WishLists item)
        {
            throw new NotImplementedException();
        }



        public async Task<IEnumerable<WishLists>> GetAllWishlistItems()
        {
            return await context.WishLists.ToListAsync();
        }
    }
}
