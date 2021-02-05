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
    public class CartsController : ControllerBase
    {
        private readonly ICartRepository repository;
        public CartsController(ICartRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carts>>> GetCartItems()
        {
            var cartItems = await repository.GetAllCartItems();
            if (cartItems == null)
                return NotFound();

            return Ok(cartItems);
        }

        [HttpPost]
        public async Task<ActionResult<Carts>> AddToCart(Carts cart)
        {
            Carts addedCart = await repository.AddToCart(cart);
            if (addedCart == null)
                return BadRequest("Cart not added");
            return Ok(addedCart);
        }

        [Route("IncreaseItemQuantity/{id}")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Carts>> IncreaseItem(int id)
        {
            return Ok(await repository.IncreaseQuantity(id));
        }



        [Route("DecreaseItemQuantity/{id}")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Carts>> DecreaseItem(int id)
        {
            return Ok(await repository.DecreaseQuantity(id));


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Carts>> DeleteItemFromCart(int id)
        {
            Carts deletedCart = await repository.DeleteFromCart(id);
            if (deletedCart == null)
                return BadRequest("Cart Not Deleted!");
            return Ok(deletedCart);
        }



        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteAllCartItems()
        {
            return Ok(await repository.DeleteAllCartItems());
        }
    }
}