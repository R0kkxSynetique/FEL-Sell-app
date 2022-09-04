using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel
{
    public class Drinks : Items
    {
        private List<string> _ingredients = new();
        public List<string> Ingredients
        {
            get => _ingredients;
        }

        public Drinks(string name, double price, List<string> Ingredients, double deposit) : base(price, name, deposit)
        {
            _ingredients = Ingredients;
        }
    }
}
