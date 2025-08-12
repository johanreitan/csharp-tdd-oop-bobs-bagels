using exercise.main;

Console.WriteLine("hello");

Basket b = new Basket(4);

IProduct bagel1 = new Bagel("BGLO", 49, "Onion");
IProduct bagel2 = new Bagel("BGLO", 49, "Onion");
IProduct bagel3 = new Bagel("BGLO", 49, "Onion");
IProduct bagel4 = new Bagel("BGLO", 49, "Onion");

b.AddProduct(bagel1);
b.AddProduct(new Bagel("BGLP", 39, "Plain"));
b.AddProduct(bagel2);
b.AddProduct(bagel4);
b.RemoveProductById(1);
b.RemoveProductById(2);

b.AddProduct(new Bagel("BGLE", 49, "Everything"));

b.Products.ForEach(p => Console.WriteLine(p.Id));

Console.WriteLine();
Console.WriteLine();

Inventory i = new Inventory();


Basket b1 = new Basket(4);

Bagel bagel123 = i.PlainBagel;
bagel123.AddFilling(i.HamFilling);

b1.AddProduct(i.PlainBagel);
b1.AddProduct(i.LatteCoffee);
b1.AddProduct(bagel123);

Console.WriteLine(b1.TotalCost);

Console.WriteLine();

b1.CheckOut();

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Testing SORTING:");

Basket basket2  = new Basket(10);
basket2.AddProduct(i.BlackCoffee);
basket2.AddProduct(i.PlainBagel);
basket2.AddProduct(i.PlainBagel);
basket2.AddProduct(i.PlainBagel);
basket2.AddProduct(i.SesameBagel);
basket2.AddProduct(i.PlainBagel);
basket2.AddProduct(i.WhiteCoffee);
basket2.AddProduct(i.PlainBagel);
basket2.AddProduct(i.PlainBagel);

basket2.CheckingOut();