﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class ProductsController : Controller
    {
        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("customerName") == null)
            {
                return RedirectToAction("Index", "Account");
            }
            else
            {
                List<Products> ProductsList = new List<Products>();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("http://localhost:53426/api/Products"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ProductsList = JsonConvert.DeserializeObject<List<Products>>(apiResponse);
                    }

                }

                return View(ProductsList.Take(12));
            }

        }
        [HttpGet]
        public async Task<IActionResult> ViewProduct(int id)
        {
            Products getProduct = new Products();
            IEnumerable<Vendors> vendorList = new List<Vendors>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/products/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    getProduct = JsonConvert.DeserializeObject<Products>(apiResponse);
                }
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/vendors/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    vendorList = JsonConvert.DeserializeObject<IEnumerable<Vendors>>(apiResponse);
                }
            }
            TempData["ProductId"] = id;
            //double amount = getProduct.Price;
            //ViewBag.price = amount;
            ProductViewModel productModel = new ProductViewModel();

            //product is out of stock
            if (vendorList == null)
            {
                productModel.product = getProduct;
                productModel.DeliveryDate = DateTime.UtcNow.AddDays(12);
            }
            else
            {
                productModel.product = getProduct;
                productModel.DeliveryDate = DateTime.UtcNow.AddDays(12);
                productModel.Vendors = vendorList;
            }
            return View(productModel);
        }

        public async Task<IActionResult> SerachProductByName(string item)
        {
            IEnumerable<Products> prod = new List<Products>();
              using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/products/" + item))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    prod = JsonConvert.DeserializeObject<IEnumerable<Products>>(apiResponse);
                }
            }
            return View("Index",prod);
        }



        [HttpPost]
        public async Task<ActionResult> ViewProduct(ProductViewModel model)
        {
            int productId = (int)TempData["ProductId"];
            //TempData.Keep("ProductId");
            Products getProduct = new Products();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44307/api/products/" + productId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    getProduct = JsonConvert.DeserializeObject<Products>(apiResponse);
                }
            }
            if (model.VendorId != 0)
            {
                Carts cartItem = new Carts();
                Carts cartReturned = new Carts();
                cartItem.ProductId = productId;
                cartItem.ZipCode = model.ZipCode;
                cartItem.DeliveryDate = model.DeliveryDate;
                cartItem.VendorId = model.VendorId;
                cartItem.Quantity = model.Quantity;
                cartItem.Price = getProduct.Price;
                StringContent content = new StringContent(JsonConvert.SerializeObject(cartItem), Encoding.UTF8, "application/json");
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync("https://localhost:44307/api/carts/", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cartReturned = JsonConvert.DeserializeObject<Carts>(apiResponse);
                    }
                }
                if (cartReturned == null)
                    return Content("There is some issue");
                return RedirectToAction("Index", "Carts");
            }
            else
            {
                WishLists wishlistItem = new WishLists()
                {
                    VendorId = model.VendorId,
                    ProductId = productId,
                    Quantity = model.Quantity,
                    DateAdded = DateTime.UtcNow,
                    CustomerId = HttpContext.Session.GetInt32("customerId")
                };
                WishLists returnedItem = new WishLists();
                StringContent content = new StringContent(JsonConvert.SerializeObject(wishlistItem), Encoding.UTF8, "application/json");
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync("https://localhost:44307/api/wishlist/", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        returnedItem = JsonConvert.DeserializeObject<WishLists>(apiResponse);
                    }
                }
                if (returnedItem == null)
                    return Content("There is some issue");
                return RedirectToAction("Index", "Wishlist");
            }

         
        }
    }
}
