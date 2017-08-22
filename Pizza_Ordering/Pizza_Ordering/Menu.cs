using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering
{
    public class Menu
    {
        //public PizzaDetails Pizza;
        public List<PizzaDetails> Pizzas { get; private set; }
        public Dictionary<string, PizzaDetails> menu = new Dictionary<string, PizzaDetails>()
        {
            { "panner pizza",new PizzaDetails() },
            { "nons",new PizzaDetails()}
        };
    }
}
