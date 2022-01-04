﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternDemo.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
