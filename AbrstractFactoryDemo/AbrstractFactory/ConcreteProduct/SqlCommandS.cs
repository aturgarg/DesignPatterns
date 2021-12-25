using AbrstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.ConcreteProduct
{
    public class SqlCommandS : DbCommandS
    {
        internal int _rowsAffected = -1;
        public SqlCommandS() : base()
        {
            GC.SuppressFinalize(this);
        }

        public SqlCommandS(string cmdText) : this()
        {
            CommandText = cmdText;
        }

        public SqlCommandS(string cmdText, SqlConnectionS connection) : this()
        {
            CommandText = cmdText;
            Connection = connection;
        }
        public override IDbConnectionS Connection { get; set ; }
        public override string CommandText { get; set; }
        public override int CommandTimeout { get; set; }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override int ExecuteNonQuery()
        {
            Console.WriteLine("Sucessfully ExecuteNonQuery");
            return 1;
        }

        public override object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
