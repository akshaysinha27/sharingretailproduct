using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface ICartRepository
    {
        Task<IEnumerable<Carts>> GetAllCartItems();
        Task<Carts> AddToCart(Carts cart);
        Task DeleteFromCart(Carts cart);
    }
}
