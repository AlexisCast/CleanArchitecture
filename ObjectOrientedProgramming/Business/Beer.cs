﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class Beer : Drink
    {
        private const string Category = "Cerveza";

        private decimal _alcohol;

        public string Name { get; set; }
        protected decimal Price { get; set; }
        public decimal Alcohol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                    value = 0;
                _alcohol = value;
            }
        }

        public Beer(string name, decimal price, decimal alcohol, int quanity)
            : base(quanity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }
        public string SAlcohol
        {
            get
            {
                return "Alcohol: " + _alcohol.ToString();
            }
        }
        public virtual string GetInfo()
        {
            return "Nombre: " + Name + ", Precio: $ " + Price + ", Alcohol: " + Alcohol;
        }

        public string GetInfo(string message)
        {
            return message + " " + GetInfo();
        }

        public string GetInfo(int number)
        {
            return number + ".- " + GetInfo();
        }
        public override string GetCategory()
        {
            return Category;
        }

    }

}
