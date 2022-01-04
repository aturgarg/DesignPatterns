using StrategyDesignPatternDemo.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternDemo.ConcreteStrategy
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    } 
}
