using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public partial class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] ImageName { get; set; }
        public double Rating { get; set; }
    }
}
