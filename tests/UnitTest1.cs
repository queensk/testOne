using sendMessage.CurrencyConverter;
using sendMessage.Models;
namespace tests;
using System;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
  
    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        Assert.Pass();
    }

    // [Test]
    // public void ConvertUSDToEUR_ValidInput_ReturnsCorrectAmount()
    // {
    //     var result = CurrencyConverterUsdToEur.USDToEUR(1);
    //     Assert.That(result, Is.EqualTo(0.91).Within(0.01));
    // }

    [Test]
    [TestCase(1, 0.91)]
    [TestCase(0, 0)]
    [TestCase(-1, -0.91)]
    [TestCase(double.MaxValue, double.MaxValue*0.91)]
    [TestCase(double.MinValue, double.MinValue*0.91)]
    [TestCase(double.PositiveInfinity, double.PositiveInfinity*0.91)]
    [TestCase(double.NegativeInfinity, double.NegativeInfinity*0.91)]
    
    public void ConvertUSDToEUR_ValidInput_ReturnsCorrectAmount_TestCase(double input, double expected)
    {
        var result = CurrencyConverterUsdToEur.USDToEUR(input);
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    [Test]
    public void ShoppingCart_AddItem_ItemAddedToInventoryAndCart()
    {
        // Arrange
        ShoppingCart cart = new ShoppingCart();
        Inventory inventory = new Inventory();
        Product product = new Product("123", "Sample Product", 10.99);
        
        // Act
        cart.AddItem(product);
        
        // Assert
        Assert.IsTrue(cart.Contains(product));
        Assert.IsFalse(inventory.HasItem(product));
    }

    // email validation tests
    [Test]
    [TestCase("example@example.com", true)]
    [TestCase("example@example", false)]
    [TestCase("exampleexample.com", false)]
    [TestCase("XXXXXXXXXXXXXXXXX", false)]
    [TestCase("", false)]
    [TestCase(" ", false)]
    [TestCase("example @example.com", false)]
    [TestCase("example@example.com;", false)]
    [TestCase("example@.com", false)]
    [TestCase("@.com", false)]
    [TestCase("example@example@example.com", false)]
    [TestCase("example@example.co.uk", true)]
    [TestCase("example+test@example.com", true)]
    [TestCase("example.test@example.com", true)]
    public void EmailValidation_ValidInput_ReturnsCorrectResult(string input, bool expected)
    {
        bool result = User.IsValidEmail(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void EmailValidation_WithNull_ThrowsArgumentNullException()
    {
        // Arrange
        string email = null;
        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => User.IsValidEmail(email));
    }



}