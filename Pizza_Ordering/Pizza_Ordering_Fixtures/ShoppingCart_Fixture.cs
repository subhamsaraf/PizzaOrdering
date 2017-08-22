using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza_Ordering;

namespace Pizza_Ordering_Fixtures
{
    [TestClass]
    public class ShoppingCart_Fixture
    {
        [TestMethod]
        public void Pizza_added_in_the_cart_should_increase_cart_count()
        {
            PizzaDetails Pizza = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            ShoppingCart cart = new ShoppingCart();
            cart.Add(Pizza);
            Assert.AreEqual(1, cart.View().Count);
        }




        [TestMethod]
        public void Items_added_in_cart_gets_removed()
        {
            PizzaDetails Pizza = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            ShoppingCart cart = new ShoppingCart();
            cart.Add(Pizza);
            cart.Remove(Pizza);
            Assert.AreEqual(0, cart.View().Count);
        }




        [TestMethod]
        public void Ordering_less_than_2_pizzas()
        {
            PizzaDetails Pizza = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            ShoppingCart cart = new ShoppingCart();
            cart.Add(Pizza);
            string s = cart.Order();
            string x = "Add Items To cart, to reach minimum Pizza order";
            Assert.AreEqual(x, s);
        }



        [TestMethod]
        public void Ordering_more_than_2_pizzas()
        {
            PizzaDetails Pizza = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            ShoppingCart cart = new ShoppingCart();
            cart.Add(Pizza);
            PizzaDetails Pizza1 = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            cart.Add(Pizza1);
            PizzaDetails Pizza2 = new PizzaDetails()
            {
                PizzaType = "Veg",
                PizzaName = "XYZ",
                PizzaPrice = 300

            };
            cart.Add(Pizza2);
            string s = cart.Order();
            string x = "order for 3 Pizza Confirmed";
            Assert.AreEqual(x, s);
        }




        [TestMethod]
        public void Cart_is_empty_when_viewd_without_adding_in_the_cart()
        {
            ShoppingCart cart = new ShoppingCart();
            var items = cart.View();
            Assert.AreEqual(0, items.Count);

        }
    }
}
