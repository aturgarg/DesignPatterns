using ObserverPatternDemo.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo.ConcreteSubjects
{
    class Carrots: Veggies
    {
        public Carrots(double price) : base(price) { }
    }
}
