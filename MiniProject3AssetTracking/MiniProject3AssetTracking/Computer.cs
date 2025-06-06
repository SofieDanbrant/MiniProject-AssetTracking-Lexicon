using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3AssetTracking
{
    class Computer : Asset
    {
        public Computer(string brand, string model, double price, DateOnly purchaseDate)
        {
            Brand = brand;
            Model = model;
            Price = price;
            PurcaseDate = purchaseDate;
            Type = AssetType.Computer;
        }
    }
}
