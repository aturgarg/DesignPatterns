using AbrstractFactory.AbstractFactory;
using AbrstractFactory.AbstractProduct;
using AbrstractFactory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.ConcreteProduct
{

    public class SqlConnectionS : DbConnectionS
    {
        public SqlConnectionS():base()
        {

        }
        
        public SqlConnectionS(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public override string ConnectionString { get; set; }
        public override string Database { get; }

        public override string DataSource { get; }

        public override void Close()
        {
            Console.WriteLine($"Sql Connection Close {ConnectionString}");
        }

        public override DbCommandS CreateDbCommand()
        {
            return new SqlCommandS(ConnectionString);
        }

        public override DbCommandS CreateCommand()
        {
            return new SqlCommandS(ConnectionString);
        }

        protected override DbProviderFactoryS DbProviderFactoryS
        {
            get => SqlClientFactoryS.Instance;
        }

        public override void Open()
        {
            Console.WriteLine($"Sql Connection Open {ConnectionString}");
        }
    }
}
