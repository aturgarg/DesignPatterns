using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.ConcreteProducts
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum Credit Card";
        }

        public int GetCreditLimit()
        {
            return 200000;
        }
    }
}
