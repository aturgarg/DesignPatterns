using AbrstractFactory.AbstractFactory;
using AbrstractFactory.AbstractProduct;
using AbrstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.ConcreteFactory
{
    public sealed class OracleClientFactoryS : DbProviderFactoryS
    {

        public static readonly OracleClientFactoryS Instance = new OracleClientFactoryS();

        private OracleClientFactoryS()
        {
        }

        public override DbConnectionS CreateConnection()
        {
            return new OracleConnectionS();
        }

        public override DbCommandS CreateCommand()
        {
            return new OracleCommandS();
        }
    }
}

