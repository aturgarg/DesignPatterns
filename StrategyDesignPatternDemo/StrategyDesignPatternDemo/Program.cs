using StrategyDesignPatternDemo.ConcreteStrategy;
using StrategyDesignPatternDemo.Context;
using System;

namespace StrategyDesignPatternDemo
{
    public class Program
    {
        //The Strategy Design Pattern is used when we have multiple algorithms(solutions) for a specific task and
        //the client decides the actual implementation to be used at runtime.
       //In simple words, we can say that the Strategy Design Pattern(also called policy pattern)
       //attempts to solve the issue where you need to provide multiple solutions for the same problem so that one can be selected at runtime.
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type : CreditCard or DebitCard or Cash ");
            Console.WriteLine("1.CreditCard ");
            Console.WriteLine("2.DebitCard");
            Console.WriteLine("3.Cash");
            Console.WriteLine("4.UPI");
            int PaymentType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Payment type is : " + PaymentType);
            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);
            PaymentContext context = new PaymentContext();

            switch (PaymentType)
            {
                case 1:
                    context.SetPaymentStrategy(new CreditCardPaymentStrategy());
                    break;
                case 2:
                    context.SetPaymentStrategy(new DebitCardPaymentStrategy());
                    break;
                case 3:
                    context.SetPaymentStrategy(new CashPaymentStrategy());
                    break;
                case 4:
                    context.SetPaymentStrategy(new UPIPaymentStrategy());
                    break;
                default:
                    break;
            }           
            context.Pay(Amount);
            Console.ReadKey();
        }
    }
}
