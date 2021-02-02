﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Vendors> Vendors { get; set; }
        public Products product { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Zipcode Required!")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Select Vendor!")]
        public int VendorId { get; set; }
    }
}
