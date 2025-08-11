using exercise.main;

namespace exercise.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddingOneBagelShouldMakeBasketNotEmpty()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");

        basket.AddProduct(b1);


        Assert.That(basket.Products.Count, Is.AtLeast(1));
    }

    [Test]
    public void RemovingOneBagelShouldMakeBasketCountOne()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");
        Bagel b2 = new Bagel("BGLP", 49, "plain");
        basket.AddProduct(b1);
        basket.AddProduct(b2);


        basket.RemoveProductById(1);

        Assert.That(basket.Products.Count, Is.AtLeast(1));
    }

    [Test]
    public void AddingOneBagelToFullBasketShouldReturnFalse()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");
        Bagel b2 = new Bagel("BGLP", 49 , "plain");
        Bagel b3 = new Bagel("BGLP", 49, "plain");
        Bagel b4 = new Bagel("BGLP", 49, "plain");
        Bagel b5 = new Bagel("BGLP", 49, "plain");
        basket.AddProduct(b1);
        basket.AddProduct(b2);
        basket.AddProduct(b3);
        basket.AddProduct(b4);



        Assert.That(basket.AddProduct(b5), Is.False);
    }


    [Test]
    public void ChangingCapacityToTenShouldMakeCapacityTen()
    {
        Basket basket = new Basket(4);

        basket.ChangeCapacity(10);

        Assert.That(basket.Capacity, Is.EqualTo(10));
    }


    [Test]
    public void RemovingItemThatDoesNotExistShouldReturnFalse()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");
        basket.AddProduct(b1);
        

        Assert.That(basket.RemoveProductById(2), Is.False);
    }

    [Test]
    public void TwoBagels49EachShouldGive98Total()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");
        Bagel b2 = new Bagel("BGLP", 49, "Plain");

        basket.AddProduct(b1);
        basket.AddProduct(b2);


        Assert.That(basket.TotalCost, Is.EqualTo(98));
    }

    [Test]
    public void PlainBagelWithCheeseAndOnionBagelWithEggShouldBe112()
    {
        Basket basket = new Basket(4);
        Bagel b1 = new Bagel("BGLO", 49, "onion");
        Bagel b2 = new Bagel("BGLP", 39, "Plain");

        Filling f1 = new Filling("FILC", 12, "Cheese");
        Filling f2 = new Filling("FILE", 12, "Egg");
        b1.AddFilling(f1);
        b2.AddFilling(f2);

        basket.AddProduct(b1);
        basket.AddProduct(b2);

        Assert.That(basket.TotalCost, Is.EqualTo(112));
    }

    [Test]
    public void Testyyy()
    {
        Inventory inventory = new Inventory();
        Bagel b1 = inventory.PlainBagel;
    }
}