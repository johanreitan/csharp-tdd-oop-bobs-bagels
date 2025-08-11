using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Bagel : IProduct
    {
        //private members
        private string _sku;
        private decimal _price;
        private int _id;
        private string _name;
        private string _variant;

        public Bagel(string sku, decimal price, int id, string name, string variant)
        {
            _sku = sku;
            _price = price;
            _id = id;
            _name = name;
            _variant = variant;
        }

        public string Sku { get; set; } 
        public decimal Price { get; set; }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Variant { get; set; }

    }
}
