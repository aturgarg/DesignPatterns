using System;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var MoneyBack =CreditCards
                            .InitializeFactories()
                            .ExecuteCreation(CreditCardTypes.MoneyBack);
            var Platinum = CreditCards
                            .InitializeFactories()
                            .ExecuteCreation(CreditCardTypes.Platinum);
            var Titanium=  CreditCards
                            .InitializeFactories()
                            .ExecuteCreation(CreditCardTypes.Titanium);

            Console.WriteLine("<--Concreate Product A-->");
            Console.WriteLine(MoneyBack.GetCardType());
            Console.WriteLine(MoneyBack.GetCreditLimit());
            Console.WriteLine(MoneyBack.GetAnnualCharge());

            Console.WriteLine("<--Concreate Product B-->");
            Console.WriteLine(Platinum.GetCardType());
            Console.WriteLine(Platinum.GetCreditLimit());
            Console.WriteLine(Platinum.GetAnnualCharge());

            Console.WriteLine("<--Concreate Product C-->");
            Console.WriteLine(Titanium.GetCardType());
            Console.WriteLine(Titanium.GetCreditLimit());
            Console.WriteLine(Titanium.GetAnnualCharge());
            Console.ReadLine();
        }
    }
}
