using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Coffee : IProduct
    {
        private int _id;
        private string _sku;
        private decimal _price;
        private string _name;
        private string _variant;

        public Coffee(string sku, decimal price, string variant)
        {
            _sku = sku;
            _price = price;
            _name = "Coffee";
            _variant = variant;
        }

        public string Sku { get { return _sku; } set { _sku = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Variant { get { return _variant; } set { _variant = value; } }
        public decimal TotalCost { get { return _price; } }
    }
}
