using FactoryMethodDemo.ConcreteImpl;
using FactoryMethodDemo.Creator;

namespace FactoryMethodDemo.ConcreteCreator
{
    public class MoneyBackFactory : CreditCardFactory
    {
        public override ICreditCard MakeCreditCard()
        {
            return new MoneyBack();
        }
    }
}
