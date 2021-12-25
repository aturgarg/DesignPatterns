using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.AbstractProduct
{   
    public interface IDbCommandS : IDisposable
    {
        IDbConnectionS Connection { get; set; }
        string CommandText { get; set; }
        int CommandTimeout { get; set; }       
        void Prepare();     
        void Cancel();        
        int ExecuteNonQuery();       
        object ExecuteScalar();
    }
}
