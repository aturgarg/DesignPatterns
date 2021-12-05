using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.ConcreteProducts
{
    //
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "MoneyBack Credit Card";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}
