using System;
using System.Linq;
using System.Threading.Tasks;

namespace amMonitor.Models
{
    public interface IMonitorRepository : IDisposable
    {
        //IQueryable<ModelKeyboardMouseLog> GetKeyboardMouseLogs(Int32 pageSize, Int32 pageNumber, String name);

        //Task<ModelKeyboardMouseLog> GetKeyboardMouseLogAsync(ModelKeyboardMouseLog entity);

        Task<ModelKeyboardMouseLog> AddKeyboardMouseLogAsync(ModelKeyboardMouseLog entity);

        Task<ModelKeyboardMouseLog> UpdateKeyboardMouseLogAsync(ModelKeyboardMouseLog changes);

        Task<ModelKeyboardMouseLog> DeleteKeyboardMouseLogAsync(ModelKeyboardMouseLog changes);


        //IQueryable<ModelScreenCapture> GetScreenCaptures(Int32 pageSize, Int32 pageNumber, String name);

        //Task<ModelScreenCapture> GetScreenCaptureAsync(ModelScreenCapture entity);

        Task<ModelScreenCapture> AddScreenCaptureAsync(ModelScreenCapture entity);

        //Task<ModelScreenCapture> UpdateScreenCaptureAsync(ModelScreenCapture changes);

        Task<ModelScreenCapture> DeleteScreenCaptureAsync(ModelScreenCapture changes);
    }
}
