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
    public sealed class SqlClientFactoryS : DbProviderFactoryS
    {

        public static readonly SqlClientFactoryS Instance = new SqlClientFactoryS();

        private SqlClientFactoryS()
        {
        }

        public override DbConnectionS CreateConnection()
        {
            return new SqlConnectionS();
        }

        public override DbCommandS CreateCommand()
        {
            return new SqlCommandS();
        }
    }
}
