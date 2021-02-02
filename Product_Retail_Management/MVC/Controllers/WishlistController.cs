using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class WishlistController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<WishLists> items = new List<WishLists>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/wishlist"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<IEnumerable<WishLists>>(apiResponse);
                }
            }
            return View(items);
        }
    }
       
}

