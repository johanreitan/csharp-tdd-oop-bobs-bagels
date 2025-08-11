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
        Basket basket = new Basket();
        Bagel b1 = new Bagel("BGLO", 49, 1, "Bagel", "onion");

        basket.AddProduct(b1);


        Assert.That(basket.Products.Count, Is.AtLeast(1));
    }

    [Test]
    public void RemovingOneBagelShouldMakeBasketCountOne()
    {
        Basket basket = new Basket();
        Bagel b1 = new Bagel("BGLO", 49, 1, "Bagel", "onion");
        Bagel b2 = new Bagel("BGLP", 49, 2, "Bagel", "plain");
        basket.AddProduct(b1);
        basket.AddProduct(b2);


        basket.RemoveProductById(1);




        Assert.That(basket.Products.Count, Is.AtLeast(1));
    }
}