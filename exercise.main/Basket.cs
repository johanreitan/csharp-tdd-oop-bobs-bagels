using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _capacity;
        private List<IProduct> _products;

        public Basket()
        {
            _products = new List<IProduct>();
        }

        public bool IsFull()
        {
            return _products.Count < _capacity;
        }

        public void AddProduct(IProduct product)
        {
           _products.Add(product);
        }

        public void RemoveProductById(int id)
        {
            IProduct productToRemove = _products.FirstOrDefault(product => product.Id == id);
            _products.Remove(productToRemove);
        }

        public List<IProduct> Products { get { return _products; } }

    }
}
