using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MVC.Models;
using Microsoft.AspNetCore.Authentication;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        private static string WebAPIurl = "https://localhost:44307/";
        //private const string SessionToken = "token";
        
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            Customers customer = new Customers();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(WebAPIurl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType: "application/json"));
                var responseMessage = await client.GetAsync(requestUri: "Account/GetCustomer?username="+model.Username+"&password="+model.Password);
                if(responseMessage.IsSuccessStatusCode)
                {
                    string apiResponse = await responseMessage.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customers>(apiResponse);
                    
                }
            }
           

            if (customer != null)
            {
                HttpContext.Session.SetString("customerName", customer.FirstName);
                HttpContext.Session.SetInt32("customerId", customer.CustomerId);

                return RedirectToAction("Index", "Products");

            }
            else
                return Content("You're not a customer! Return to Login Page!");
        }

        public async Task<ActionResult> GetEmployee()
        {
            string returnMessage = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(WebAPIurl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType: "application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "Bearer", 
                    parameter: HttpContext.Session.GetString("token"));
                var responseMessage = await client.GetAsync(requestUri: "Account/GetEmployee");
                if(responseMessage.IsSuccessStatusCode)
                {
                    var resultMessage = responseMessage.Content.ReadAsStringAsync().Result;
                    returnMessage = JsonConvert.DeserializeObject<string>(resultMessage);
                    
                }
            }
            return Content(returnMessage);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }

    }
}
