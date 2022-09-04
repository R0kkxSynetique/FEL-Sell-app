using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel
{
    public class Carts
    {
        public List<Items> Cart;
        public double Total;

        public Carts()
        {
            Cart = new();
        }

        public void AddToCart(Items item)
        {
            Cart.Add(item);
        }

        public void RemoveFromCart(Items item)
        {
            Cart.Remove(item);
        }

        public void CleanCart()
        {
            Cart.Clear();
            Total = 0;
        }

        private void AddToTotal(Items item)
        {
            Total += item.Price;
        }

        public double CalculateTotal()
        {
            Cart.ForEach(AddToTotal);
            return Total;
        }
    }
}
