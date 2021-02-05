using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public partial class WishLists
    {
        [Key]
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerId { get; set; }
        public virtual Products Product { get; set; }
        public virtual Vendors Vendor { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
