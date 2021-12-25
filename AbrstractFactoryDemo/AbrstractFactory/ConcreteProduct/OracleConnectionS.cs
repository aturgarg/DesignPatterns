using AbrstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.ConcreteProduct
{
    public class OracleConnectionS : DbConnectionS
    {
        public OracleConnectionS():base()
        {

        }

        public OracleConnectionS(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public override string ConnectionString { get; set; }
        public override string Database { get; }

        public override string DataSource { get; }

        public override void Close()
        {
            Console.WriteLine($"Oracle Connection Close {ConnectionString}");
        }

        public override DbCommandS CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override DbCommandS CreateDbCommand()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            Console.WriteLine($"Oracle Connection Open {ConnectionString}");
        }
    }
}
