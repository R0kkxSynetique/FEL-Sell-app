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
        public double Total
        {
            get => _total;
        }

        private double _total = 0;

        public Carts(List<Items> items)
        {
            Cart = new(items);
        }

        public double CalculateTotal()
        {
            double subtotal = 0;
            foreach(Items item in Cart)
            {
                subtotal += item.Price * item.Quantity + item.Deposit * item.Quantity;
            }

            _total = subtotal;

            return _total;
        }
    }
}
