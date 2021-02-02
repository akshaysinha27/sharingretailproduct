using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class CartsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Carts> cartItems = new List<Carts>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/carts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItems = JsonConvert.DeserializeObject<IEnumerable<Carts>>(apiResponse);
                }
            }
            return View(cartItems);
        }
    }
}
