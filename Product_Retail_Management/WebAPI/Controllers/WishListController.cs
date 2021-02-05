using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly IWishListRepository repository;
        public WishListController(IWishListRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WishLists>>> GetWishListItems()
        {
            var items = await repository.GetAllWishlistItems();
            if (items == null)
                return NotFound();

            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult<WishLists>> AddToWishList(WishLists item)
        {
            WishLists addedItem = await repository.AddToWishlist(item);
            if (addedItem == null)
                return BadRequest("Cart not added");
            return Ok(addedItem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WishLists>> DeleteItemFromWishlist(int id)
        {
            var deletedItem = await repository.DeleteFromWishlist(id);
            if (deletedItem == null)
                return BadRequest("Wishlist Item Not Deleted!");



            return Ok(deletedItem);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<WishLists>> DecreaseQuantity(int id)
        {
            return Ok(await repository.DecreaseQuantity(id));
        }
    }
}