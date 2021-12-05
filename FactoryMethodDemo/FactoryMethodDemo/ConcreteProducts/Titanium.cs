using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.ConcreteProducts
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 3000;
        }

        public string GetCardType()
        {
            return "Titanium Credit Card";
        }

        public int GetCreditLimit()
        {
            return 300000;
        }
    }
}
