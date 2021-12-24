using FactoryMethodDemo.ConcreteImpl;
using FactoryMethodDemo.Creator;

namespace FactoryMethodDemo.ConcreteCreator
{
    public class PlatinumFactory : CreditCardFactory
    {
        public override ICreditCard MakeCreditCard()
        {
            return new Platinum();
        }
    }
}
