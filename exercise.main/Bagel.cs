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
        private List<Filling> _fillings;

        public Bagel(string sku, decimal price, string variant)
        {
            _sku = sku;
            _price = price;
            _name = "Bagel";
            _variant = variant;
            _fillings = new List<Filling>();
        }

        public string Sku { get; set; } 
        public decimal Price { get { return _price; } set { _price = value; } }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Variant { get; set; }
        public List<Filling> Fillings { get { return _fillings; } }

        public decimal CostOfFillings { get { return _fillings.Sum(f => f.Price); } }

        public decimal TotalCost {  get { return _price + CostOfFillings; } }

        public void AddFilling(Filling filling)
        {
            _fillings.Add(filling);
        }

    }
}
