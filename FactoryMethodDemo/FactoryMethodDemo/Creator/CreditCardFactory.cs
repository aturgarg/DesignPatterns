using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.Creator
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard MakeCreditCard();

        public ICreditCard Create()
        {
            return this.MakeCreditCard();
        }
    }
}
