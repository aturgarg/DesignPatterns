using FactoryMethodDemo.ConcreteImpl;
using FactoryMethodDemo.Creator;

namespace FactoryMethodDemo.ConcreteCreator
{
    public class TitaniumFactory : CreditCardFactory
    {
        public override ICreditCard MakeCreditCard()
        {
            return new Titanium();
        }
    }
}
