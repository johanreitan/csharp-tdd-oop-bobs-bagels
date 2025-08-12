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
        private decimal _discount = 0;

        public Basket(int capacity = 4)
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
            if (!IsFull() && product != null)
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

        public void CheckingOut()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bobs Bagels");
            sb.AppendLine("---");
            int noBagels = 0;
            int noCoffees = 0;
            var SortedProducts = _products.OrderBy(product => product.Sku);

            foreach (var product in SortedProducts)
            {
               if (product.Sku.StartsWith("B"))
                {
                    noBagels++;
                }

                if (product.Sku.StartsWith("C")) {
                    noCoffees++;
                }

                sb.AppendLine($"{product.Name}, {product.Variant} --- {product.TotalCost}");
            }

            sb.AppendLine();
            sb.AppendLine($"{TotalCost}");

            sb.AppendLine();
            sb.AppendLine("Discounts:");

            while (noBagels >= 6)
            {
                if (noBagels >= 12)
                {
                    sb.AppendLine();
                }
            }

           
            Console.WriteLine(sb.ToString());
           
        }

        public void CheckOut()
        {


            Receipt receipt = new Receipt(_products, TotalCost);

            string receiptPrint = receipt.ReceiptString();

            Console.WriteLine(receiptPrint);
        }


        public void CalculateDiscount()
        {
            if (IsTwelveBagels())
            {
                //work out discount (adding up price of twelve bagels) that - 3.99

                decimal tempPrice = _products.Where(x => x is Bagel).Take(12).Sum(y => y.TotalCost);

                Discount += (tempPrice - 3.99m);
                return;
            }
            if (IsSixBagels())
            {
                decimal tempPrice = _products.Where(x => x is Bagel).Take(6).Sum(y => y.TotalCost);
                Discount += (tempPrice - 2.49m);
                return;
            }
            if (IsCoffeeAndBagel())
            {
                decimal tempPrice = _products.First(x => x is Coffee).TotalCost + _products.First(y => y is Bagel).TotalCost;
                Discount += (tempPrice - 1.25m);
                return;
            }
        }

        public bool IsCoffeeAndBagel()
        {
            return _products.Any(x => x is Bagel) && _products.Any(y => y is Coffee);
        }

        public bool IsTwelveBagels()
        {
            return _products.Count(p => p.Name.Equals("Bagel")) >= 12;
        }
        public bool IsSixBagels()
        {
            return _products.Count(p => p.Name.Equals("Bagel")) >= 6;
        }

        public List<IProduct> Products { get { return _products; } }
        public int Capacity { get { return _capacity; } }
        public decimal Discount { get { return _discount; } set { _discount = value; } }
        public decimal TotalCost { get { return _products.Sum(product => product.TotalCost) - Discount; } }


    }
}
