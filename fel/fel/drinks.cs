using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel
{
    public class Drinks : Items
    {
        public Drinks(double price, string name, double deposit, int quantity) : base(price, name, deposit, quantity)
        {
        }
    }
}
