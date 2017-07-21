using Microsoft.EntityFrameworkCore;

namespace amMonitor.Models
{
    public static class ModelKeyboardMouseLogMap
    {
        public static ModelBuilder MapKeyboardMouseLog(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ModelKeyboardMouseLog>();

            entity.ToTable("KeyboardMouseLog", "Production");

            entity.HasKey(p => new { p.ModelKeyboardMouseLogId});

            entity.Property(p => p.ModelKeyboardMouseLogId).UseSqlServerIdentityColumn();

            return modelBuilder;
        }
    }
}
