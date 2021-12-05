using FactoryMethodDemo.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodDemo
{
    public class CreditCards
    {
        private readonly Dictionary<CreditCardTypes, CreditCardFactory> _factories;

        private CreditCards()
        {
            _factories = new Dictionary<CreditCardTypes, CreditCardFactory>();
            if (!_factories.Any())
            {
                foreach (CreditCardTypes CreditCardType in Enum.GetValues(typeof(CreditCardTypes)))
                {
                    var factory = (CreditCardFactory)Activator
                                   .CreateInstance(Type.GetType("FactoryMethodDemo.ConcreteCreator." + Enum.GetName(typeof(CreditCardTypes), CreditCardType) + "Factory"));
                    _factories.Add(CreditCardType, factory);
                }
            }
        }

        public static CreditCards InitializeFactories() => new CreditCards();

        public ICreditCard ExecuteCreation(CreditCardTypes creditCardTypes) => _factories[creditCardTypes].MakeCreditCard();


    }

    public enum CreditCardTypes
    {
        MoneyBack,
        Platinum,
        Titanium
    }
}
