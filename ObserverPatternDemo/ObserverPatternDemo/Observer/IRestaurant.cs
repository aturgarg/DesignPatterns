using ObserverPatternDemo.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo.Observer
{
    public interface IRestaurant
    {
        void Update(Veggies veggies);
    }
}
