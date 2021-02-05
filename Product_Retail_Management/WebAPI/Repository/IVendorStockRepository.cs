﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IVendorStockRepository
    {
        Task<VendorStocks> UpdateStock(Carts cart);
        Task<int> GetProductQuantity(int productId);
    }
}
