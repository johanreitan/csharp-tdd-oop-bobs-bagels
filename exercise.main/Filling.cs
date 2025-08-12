using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Filling
    {
        //private members
        private string _sku;
        private decimal _price;
        private Guid _id;
        private string _name;
        private string _variant;

        public Filling(string sku, decimal price, string variant)
        {
            _id = Guid.NewGuid();
            _sku = sku;
            _price = price;
            _name = "Filling";
            _variant = variant;
        }

        public string Sku { get { return _sku; } set { _sku = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public Guid Id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Variant { get { return _variant; } set { _variant = value; } }
        public decimal TotalCost { get { return _price; } }


    }
}
