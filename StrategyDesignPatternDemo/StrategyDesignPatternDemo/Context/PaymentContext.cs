using StrategyDesignPatternDemo.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternDemo.Context
{
    public class PaymentContext
    {
        private IPaymentStrategy _PaymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) 
        {
            _PaymentStrategy = paymentStrategy;
        }

        public void Pay(double amount)
        {
            _PaymentStrategy.Pay(amount);
        }
    }
}
