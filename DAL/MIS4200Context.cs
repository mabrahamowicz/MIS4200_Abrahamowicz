using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MIS4200_Abrahamowicz.Models;


namespace MIS4200_Abrahamowicz.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, MIS4200_Abrahamowicz.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor>  doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}