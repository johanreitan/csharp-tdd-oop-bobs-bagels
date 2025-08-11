using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private static int _nextId = 1;
        private int _capacity;
        private List<IProduct> _products;

        public Basket(int capacity)
        {
            _products = new List<IProduct>();
            _capacity = capacity;
        }

        public bool IsProductInBasket(IProduct product)
        {   
            return _products.Contains(product);
        }

        public bool IsFull()
        {
            return _products.Count >= _capacity;
        }

        public bool AddProduct(IProduct product)
        {
            if (!IsFull())
            {
                product.Id = _nextId;
                _nextId++;
                _products.Add(product);
                return true;
            }
            return false;
        }

        public bool RemoveProductById(int id)
        {
            IProduct productToRemove = _products.FirstOrDefault(product => product.Id == id);
            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
                return true;
            }
            return false;
        }

        public void ChangeCapacity(int capacity)
        {
            _capacity = capacity;
        }

        public List<IProduct> Products { get { return _products; } }
        public int Capacity { get { return _capacity; } }
        public decimal TotalCost { get { return _products.Sum(product => product.TotalCost); } }

    }
}
