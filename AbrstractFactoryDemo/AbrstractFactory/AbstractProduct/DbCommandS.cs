using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.AbstractProduct
{
    public abstract class DbCommandS : IDbCommandS
    {
        protected DbCommandS()
        {
        }
        public abstract IDbConnectionS Connection { get; set; }
        public abstract string CommandText { get; set; }
        public abstract int CommandTimeout { get; set; }
        public abstract void Cancel();
        public abstract void Dispose();
        public abstract int ExecuteNonQuery();
        public abstract object ExecuteScalar();
        public abstract void Prepare();
    }
}
