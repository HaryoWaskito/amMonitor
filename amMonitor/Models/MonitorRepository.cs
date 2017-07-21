using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amMonitor.Models
{
    public class MonitorRepository : IMonitorRepository
    {
        private readonly MonitorDbContext DbContext;
        private Boolean Disposed;

        public MonitorRepository(MonitorDbContext dbContext)
        {
            DbContext = DbContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();

                    Disposed = true;
                }
            }
        }

        public Task<ModelKeyboardMouseLog> AddKeyboardMouseLogAsync(ModelKeyboardMouseLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<ModelScreenCapture> AddScreenCaptureAsync(ModelScreenCapture entity)
        {
            throw new NotImplementedException();
        }

        public Task<ModelKeyboardMouseLog> DeleteKeyboardMouseLogAsync(ModelKeyboardMouseLog changes)
        {
            throw new NotImplementedException();
        }

        public Task<ModelScreenCapture> DeleteScreenCaptureAsync(ModelScreenCapture changes)
        {
            throw new NotImplementedException();
        }

        public Task<ModelKeyboardMouseLog> UpdateKeyboardMouseLogAsync(ModelKeyboardMouseLog changes)
        {
            throw new NotImplementedException();
        }
    }
}
