using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering
{
    public class ShoppingCart
    {
        private List<string> _pizzaInCart = new List<string>();


        public void Add()
        {
            Customer customer = new Customer();
            _pizzaInCart.Add(customer.Select());
        }


        public List<string> View()
        {
            return _pizzaInCart;
        }


        public void Order()
        {
            if (_pizzaInCart.Count > 2)
            {
                var totalAmount = _pizzaInCart
            }

        }
    }
}
