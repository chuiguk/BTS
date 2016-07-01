using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Data.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class PriorityConfig : EntityTypeConfiguration<Priority>
    {
        public PriorityConfig()
        {
            HasKey(p => p.PriorityID);
            Property(p => p.Name).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
        }
    }
}