using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Data
{
    public class VendorData
    {
        public List<Vendors> GetVendorList()
        {
            return new List<Vendors>()
                {
                    new Vendors
                    {
                        VendorId = 1,
                        Name = "Vendor1",
                        DeliveryCharge = 50,
                        Rating = 4.1
                    },
                     new Vendors
                     {
                         VendorId = 2,
                         Name = "Vendor2",
                         DeliveryCharge = 40,
                         Rating = 3.4
                     },
                     new Vendors
                    {
                        VendorId = 3,
                        Name = "Vendor3",
                        DeliveryCharge = 42,
                        Rating = 4.0
                    },
                     new Vendors
                    {
                        VendorId = 4,
                        Name = "Vendor4",
                        DeliveryCharge = 30,
                        Rating = 3.4
                    },
                     new Vendors
                    {
                        VendorId = 5,
                        Name = "Vendor5",
                        DeliveryCharge = 60,
                        Rating = 4.8
                    },
                     new Vendors
                    {
                        VendorId = 6,
                        Name = "Vendor6",
                        DeliveryCharge = 45,
                        Rating = 3.5
                    },
                     new Vendors
                    {
                        VendorId = 7,
                        Name = "Vendor7",
                        DeliveryCharge = 35,
                        Rating = 4.2
                    },
                     new Vendors
                    {
                        VendorId = 8,
                        Name = "Vendor8",
                        DeliveryCharge = 50,
                        Rating = 3.8
                    },
                     new Vendors
                    {
                        VendorId = 9,
                        Name = "Vendor9",
                        DeliveryCharge = 58,
                        Rating = 4.3
                    },
                     new Vendors
                    {
                        VendorId = 10,
                        Name = "Vendor10",
                        DeliveryCharge = 70,
                        Rating = 4.6
                    },
                     new Vendors
                    {
                        VendorId = 11,
                        Name = "Vendor11",
                        DeliveryCharge = 60,
                        Rating = 4.6
                    },
                     new Vendors
                    {
                        VendorId = 12,
                        Name = "Vendor12",
                        DeliveryCharge = 20,
                        Rating = 2.7
                    }
                };
        }
    }
}
