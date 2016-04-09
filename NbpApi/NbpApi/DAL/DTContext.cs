using NbpApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NbpApi.DAL
{
    public class DTContext : DbContext
    {
        public DTContext() : base("FileInformationConnectionString")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<DTContext, ConfigurationDb>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<CurrencyInfo> CurrencyInformations { get; set; }
    }
}