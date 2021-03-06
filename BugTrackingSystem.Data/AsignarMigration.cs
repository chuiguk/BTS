﻿using System;
using System.Data.Entity;
using BugTrackingSystem.Data.Model;
using BugTrackingSystem.Data.Context;

namespace BugTrackingSystem.Data
{
    public class AsignarMigration : MigrateDatabaseToLatestVersion<BugTrackingSystem.Data.Context.AsignarContext, BugTrackingSystem.Data.Migrations.Configuration>
    {
        //protected override void Seed(Context.AsignarContext context)
        //{
        //    base.Seed(context);

        //    var financier = new Project { Name = "The Financier", Prefix = "TDF" };
        //    var orwell = new User
        //    {
        //        FirstName = "George",
        //        LastName = "Orwell",
        //        Login = "admin",
        //        Password = "password",
        //        Email = "chuiguk.eu@gmail.com",
        //        Role = 1
        //    };

        //    var bug1 = new Bug
        //    {
        //        Number = 123,
        //        Subject = "Font for password is different from other labels font on 'Login' screen",
        //        CreationDate = DateTime.UtcNow,
        //        ModificationDate = DateTime.UtcNow,
        //        Description = "Font is different!",
        //        Priority = 4,
        //        Status = 1,
        //        User = orwell,
        //        Project = financier
        //    };

        //    var bug2 = new Bug
        //    {
        //        Number = 124,
        //        Subject = "Nothing working properly",
        //        CreationDate = DateTime.UtcNow,
        //        ModificationDate = DateTime.UtcNow,
        //        Description = "Its a disaster!",
        //        Priority = 1,
        //        Status = 2,
        //        User = orwell,
        //        Project = financier
        //    };

        //    var bug3 = new Bug
        //    {
        //        Number = 125,
        //        Subject = "Button 'Submit' does not work",
        //        CreationDate = DateTime.UtcNow,
        //        ModificationDate = DateTime.UtcNow,
        //        Description = "'Submit' is broken!",
        //        Priority = 3,
        //        Status = 1,
        //        User = orwell,
        //        Project = financier
        //    };
        //    context.Bugs.Add(bug1);
        //    context.Bugs.Add(bug2);
        //    context.Bugs.Add(bug3);

        //    financier.Users.Add(orwell);

        //    context.Projects.Add(financier);

        //    context.SaveChanges();

        //    //Package Manager Console
        //    //Add-Migration {Name}
        //    //Update-Database -Verbose
        }
    }

