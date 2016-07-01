using System;
using System.Data.Entity.Migrations;
using BugTrackingSystem.Data.Context;
using BugTrackingSystem.Data.Model;

namespace BugTrackingSystem.Data.Migrations
{
    public class Configuration : DbMigrationsConfiguration<AsignarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }
            //Package Manager Console
            //Add-Migration {Name}
            //Update-Database -Verbose
        }
    }

