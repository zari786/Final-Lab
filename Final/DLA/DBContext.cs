using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Final.DLA
{
    public class DBContext : DbContext
    {
        public DBContext() : base("MyConString") { }

        //public DbSet<UserAccount> userAccounts { get; set; }
        //public DbSet<Services> services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Final.Models.Sales> Sales { get; set; }

        public System.Data.Entity.DbSet<Final.Models.Tyres> Tyres { get; set; }
    }
}