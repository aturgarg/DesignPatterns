using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.AbstractProduct
{
    public interface IDbConnectionS : IDisposable
    {
        string ConnectionString { get; set; }
        int ConnectionTimeout { get; }
        string Database { get; }
        void Close();
        void Open();
        DbCommandS CreateDbCommand();
    }
}
