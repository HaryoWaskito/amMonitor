using Microsoft.EntityFrameworkCore;

namespace amMonitor.Models
{
    public static class ModelScreenCaptureMap
    {
        public static ModelBuilder MapKeyboardMouseLog(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ModelScreenCapture>();

            entity.ToTable("ScreenCapture", "Production");

            entity.HasKey(p => new { p.ModelScreenCaptureId });

            entity.Property(p => p.ModelScreenCaptureId).UseSqlServerIdentityColumn();

            return modelBuilder;
        }
    }
}
