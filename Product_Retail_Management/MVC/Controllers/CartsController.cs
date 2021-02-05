using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

            //IEnumerable<Carts> cartItems = new List<Carts>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://localhost:44307/api/carts"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        cartItems = JsonConvert.DeserializeObject<IEnumerable<Carts>>(apiResponse);
            //    }
            //}
            //return View(cartItems);

            IEnumerable<Carts> carts;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/carts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    carts = JsonConvert.DeserializeObject<IEnumerable<Carts>>(apiResponse);
                }
            }
         

           
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.GetAsync("Carts").Result)
            //{
            //    carts = httpResponse.Content.ReadAsAsync<IEnumerable<Carts>>().Result;
            //}



            var distinctProductIds = carts.Select(p => p.ProductId).Distinct().ToList();
            List<Carts> distinctCarts = new List<Carts>();
            foreach (var id in distinctProductIds)
            {
                int quantity = 0;
                foreach (var item in carts)
                {
                    if (item.ProductId == id)
                        quantity += item.Quantity;
                }



                Carts obj = carts.Where(p => p.ProductId == id).FirstOrDefault();
                obj.Quantity = quantity;
                distinctCarts.Add(obj);
            }



            return View(distinctCarts);
        }

        public async Task<IActionResult> DeleteFromCart(int id)
        {
            Carts deletedCart;
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.DeleteAsync("Carts/" + id.ToString()).Result)
            //{
            //    deletedCart = httpResponse.Content.ReadAsAsync<Cart>().Result;
            //}
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44307/api/Carts/"+id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deletedCart = JsonConvert.DeserializeObject<Carts>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> IncreaseCartItem(int id)
        {
            Carts increaseCart;
            

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/Carts/IncreaseItemQuantity/" + id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    increaseCart = JsonConvert.DeserializeObject<Carts>(apiResponse);
                }
            }
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.GetAsync("Carts/IncreaseItemQuantity/" + id.ToString()).Result)
            //{
            //    increaseCart = httpResponse.Content.ReadAsAsync<Cart>().Result;
            //}
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> DecreaseFromCart(int id)
        {
            Carts decreaseCart;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/Carts/DecreaseItemQuantity/" + id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    decreaseCart = JsonConvert.DeserializeObject<Carts>(apiResponse);
                }
            }
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.GetAsync("Carts/DecreaseItemQuantity/" + id.ToString()).Result)
            //{
            //    decreaseCart = httpResponse.Content.ReadAsAsync<Cart>().Result;
            //}
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Checkout()
        {
            IEnumerable<Carts> carts;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/Carts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    carts = JsonConvert.DeserializeObject<IEnumerable<Carts>>(apiResponse);
                }
            }
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.GetAsync("Carts").Result)
            //{
            //    carts = httpResponse.Content.ReadAsAsync<IEnumerable<Cart>>().Result;
            //}



            //to deduct quantity of ordered products from db
            //foreach (var item in carts)
            //{
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
            //    using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.PutAsync("VendorStocks/", content).Result)
            //    {
            //        //cartReturned = httpResponse.Content.ReadAsAsync<Cart>().Result;
            //    }
            //}



            //to delete products from cart
            bool isCartEmpty;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44307/api/Carts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    isCartEmpty = JsonConvert.DeserializeObject<bool>(apiResponse);
                }
            }
            //using (HttpResponseMessage httpResponse = GlobalVariables.webApiClient.DeleteAsync("Carts").Result)
            //{
            //    isCartEmpty = httpResponse.Content.ReadAsAsync<bool>().Result;
            //}



            return View();
        }
    }
}
