using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Controllers
{
    //[System.Web.Http.Route("[controller]/[action]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ProductRetailManagementDBContext _context;
        public IConfiguration Configuration { get; }

        public AccountController(ProductRetailManagementDBContext context, IConfiguration configuration)
        {
            this.Configuration = configuration;
            _context = context;
        }


        public IActionResult ValidLogin(string username, string password)
        {
            if (_context.Customers.Where(x => x.Email == username && x.Password == password).SingleOrDefault() != null)
            {
                
                return Ok(TokenManager.GenerateToken(username));
                //return Request.CreateResponse(HttpStatusCode.OK, value:TokenManager.GenerateToken(username));
            }
            else
            {
                return BadRequest("Invalid Credentials");
            }
        }

        [CustomAuthenticationFilter]
        public Customers GetCustomer(string username, string password)
        {
            var customer = _context.Customers.Where(x => x.Email == username && x.Password == password).SingleOrDefault();
            //int customerId = customer.CustomerId;
            //this.HttpContext.Session.GetInt32("customerid");
            //HttpContext.Session.SetInt32("customerid", customerId);
            //return HttpContext.Session.GetInt32("customerid");
            return customer;
        }
    }
}
