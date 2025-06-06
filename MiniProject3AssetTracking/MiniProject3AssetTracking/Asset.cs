using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3AssetTracking
{
    abstract class Asset
    {
        public enum AssetType {Computer, Phone }
        public AssetType Type { get; protected set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public DateOnly PurcaseDate { get; set; }
    }

    abstract class Price
    {
        public double price { get; set; }
    }
}
