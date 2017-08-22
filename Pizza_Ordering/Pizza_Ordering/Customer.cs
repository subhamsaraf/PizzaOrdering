using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering
{
    public class Customer
    {
        Menu menu = new Menu();

        public string Select()
        {
            return menu.Pizzass;
        }
    }
}
