using System;
using System.Collections.Generic;

namespace fel
{
    public class Items
    {
        protected double _price;
        protected string _name;
        protected double _deposit;

        public double Price
        {
            get => _price;
        }
        public string Name
        {
            get => _name;
        }
        public double Deposit
        {
            get => _deposit;
        }

        public Items(double Price, string Name, double Deposit)
        {
            _price = Price;
            _name = Name;
            _deposit = Deposit;
        }
    }
}
