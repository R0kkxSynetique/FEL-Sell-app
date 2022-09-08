using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel
{
    public class Food : Items
    {
        private List<string> _ingredients = new();
        public List<string> Ingredients
        {
            get => _ingredients;
        }

        public Food(double price, string name, double deposit, List<string> Ingredients, int quantity) : base(price, name, deposit, quantity)
        {
            _ingredients = Ingredients;
        }
    }
}
