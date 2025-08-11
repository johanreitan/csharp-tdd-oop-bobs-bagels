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

b1.AddProduct(i.PlainBagel);
b1.AddProduct(i.LatteCoffee);

Console.WriteLine(b1.TotalCost);