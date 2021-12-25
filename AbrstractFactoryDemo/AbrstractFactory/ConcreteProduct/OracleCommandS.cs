using AbrstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.ConcreteProduct
{
    public class OracleCommandS : DbCommandS
    {
        internal int _rowsAffected = -1;
        public OracleCommandS() : base()
        {
            GC.SuppressFinalize(this);
        }

        public OracleCommandS(string cmdText) : this()
        {
            CommandText = cmdText;
        }

        public OracleCommandS(string cmdText, OracleConnectionS connection) : this()
        {
            CommandText = cmdText;
            Connection = connection;
        }
        public override IDbConnectionS Connection { get; set; }
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
