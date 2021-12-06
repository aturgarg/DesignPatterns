using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo
{
    //This Product class
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

    }
}
