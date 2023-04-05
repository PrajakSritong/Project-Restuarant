using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Spicy : Restaurantfood
    {
        private string spicy;
        public Spicy(string name, int amount, string spicy) : base(name, amount)
        {
            this.spicy = spicy;
        }
        public string getSpicy() { return spicy; }
    }
}

