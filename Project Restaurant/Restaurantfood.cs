using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Restaurantfood
    {
        private string name;
        private int amount;
        
        public Restaurantfood(string name,int amount)
        {
            this.name = name;
            this.amount = amount;
        }
        public string getName() { return name; }
        public int getAmount() { return amount; }  
        


    }   
}   
