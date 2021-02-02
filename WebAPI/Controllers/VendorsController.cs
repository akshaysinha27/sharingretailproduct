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
    public class VendorsController : ControllerBase
    {
        private IVendorRepository VendorRepository;

        private IWebHostEnvironment webHostEnvironment;
        public VendorsController(IVendorRepository repo, IWebHostEnvironment environment)
        {
            VendorRepository = repo;
            webHostEnvironment = environment;

        }



        // GET: api/Vendors
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Vendors>>> GetVendors(int id)
        {
            var vendors = await VendorRepository.GetAllVendorDetails(id);
            return Ok(vendors);
        }
    }
}