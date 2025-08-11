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

        public Coffee(int id, string sku, decimal price, string name, string variant)
        {
            _id = id;
            _sku = sku;
            _price = price;
            _name = name;
            _variant = variant;
        }

        public int Id { get; set; }
        public string Sku {  get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
    }
}
