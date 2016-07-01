using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Data.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class StatusConfig : EntityTypeConfiguration<Status>
    {
        public StatusConfig()
        {
            HasKey(s => s.StatusID);
            Property(s => s.Name).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
        }
    }
}