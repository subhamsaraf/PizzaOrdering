using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering
{
    public class ShoppingCart
    {
        private List<PizzaDetails> _pizzaInCart = new List<PizzaDetails>();


        public void Add(PizzaDetails pizza)
        {
            //Customer customer = new Customer();
            _pizzaInCart.Add(pizza);
        }


        public List<PizzaDetails> View()
        {
            return _pizzaInCart;
        }

        public void Remove(PizzaDetails pizza)
        {
            _pizzaInCart.Remove(pizza);
        }

        public string Order()
        {
            if (_pizzaInCart.Count >= 2)
            {
                return $"order for {_pizzaInCart.Count} Pizza Confirmed";
            }
            else
            {
                return "Add Items To cart, to reach minimum Pizza order";
            }
        }
    }
}
