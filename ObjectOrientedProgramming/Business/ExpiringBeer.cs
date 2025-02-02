﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal price, decimal alcohol,
            DateTime expiration, int quantity)
            : base(name, price, alcohol, quantity)
        {
            Expiration = expiration;
        }

        public override string GetInfo()//parent class must be/have virtual
        {
            return "Cerveza con caducidad: " + Name + ", Precio: $ " + Price + ", Alcohol: " + Alcohol +
                ", caducidad: " + Expiration.Date.ToString();
        }


    }
}
