using System;
using System.Collections.Generic;

namespace fel
{
    public class Items
    {
        protected double _price;
        protected string _name;
        protected double _deposit;
        protected int _quantity;

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
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Items(double Price, string Name, double Deposit, int Quantity)
        {
            _price = Price;
            _name = Name;
            _deposit = Deposit;
            _quantity = Quantity;
        }
    }
}
