using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorStocksController : ControllerBase
    {
        private readonly IVendorStockRepository _vendorStockRepository;



        public VendorStocksController(IVendorStockRepository vendorStockRepository)
        {
            _vendorStockRepository = vendorStockRepository;
        }



        // GET: api/VendorStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<int>> GetProductQuantity(int id)
        {
            return await _vendorStockRepository.GetProductQuantity(id);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVendorStock(Carts cart)
        {
            return Ok(await _vendorStockRepository.UpdateStock(cart));
        }
    }
}
