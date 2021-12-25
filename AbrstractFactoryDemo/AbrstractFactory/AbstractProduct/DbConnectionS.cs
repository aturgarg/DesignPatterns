using AbrstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrstractFactory.AbstractProduct
{
    public abstract class DbConnectionS : IDbConnectionS
    {
        private bool disposedValue;

        protected DbConnectionS()
        {
        }

        protected virtual DbProviderFactoryS DbProviderFactoryS => null;

        internal DbProviderFactoryS ProviderFactoryS => DbProviderFactoryS;
        public abstract string ConnectionString { get; set; }

        public virtual int ConnectionTimeout => 300;

        public abstract string Database { get; }

        public abstract string DataSource { get; }

        public abstract void Close();
        public abstract DbCommandS CreateDbCommand();
        public abstract DbCommandS CreateCommand();
        public abstract void Open();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

       

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
        
    }
}
