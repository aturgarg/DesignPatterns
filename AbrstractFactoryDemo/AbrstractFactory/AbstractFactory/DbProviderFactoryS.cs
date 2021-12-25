using AbrstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.AbstractFactory
{    
    public abstract  class DbProviderFactoryS
    {        

        protected DbProviderFactoryS() 
        {
        
        }       

        public virtual DbConnectionS CreateConnection() => null;
        public virtual DbCommandS CreateCommand() => null;


    }
}
