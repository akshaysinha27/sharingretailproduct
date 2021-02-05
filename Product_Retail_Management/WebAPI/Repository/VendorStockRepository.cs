using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class VendorStockRepository:IVendorStockRepository
    {
        private readonly ProductRetailManagementDBContext _context;



        public VendorStockRepository(ProductRetailManagementDBContext context)
        {
            _context = context;
        }



        public async Task<int> GetProductQuantity(int productId)
        {
            var quantities = await _context.VendorStocks.Where(p => p.ProductId == productId).Select(q => q.StockInHand).ToListAsync();
            int totalQuantity = 0;
            foreach (var item in quantities)
            {
                totalQuantity += item;
            }
            return totalQuantity;
        }



        public async Task<VendorStocks> UpdateStock(Carts cart)
        {
            VendorStocks stock = await _context.VendorStocks.Where(v => (v.VendorId == cart.VendorId) && (v.ProductId == cart.ProductId)).Include(p => p.Product).Include(v => v.Vendor).SingleOrDefaultAsync();
            stock.StockInHand -= cart.Quantity;
            _context.VendorStocks.Update(stock);
            await _context.SaveChangesAsync();
            return stock;
        }
    }
}
