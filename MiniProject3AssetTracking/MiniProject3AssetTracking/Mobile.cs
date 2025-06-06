using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3AssetTracking
{
    class Mobile : Asset
    {
        public Mobile(string brand, string model, double price, DateOnly purchaseDate)
        {
            Brand = brand;
            Model = model;
            Price = price;
            PurcaseDate = purchaseDate;
            Type = AssetType.Phone;
        }
    }
}
