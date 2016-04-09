using NbpApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace NbpApi.DAL
{
    internal sealed class ConfigurationDb : DbMigrationsConfiguration<DTContext>
    {
        public ConfigurationDb()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = "NbpApi.DAL.DTContext";
        }

        protected override void Seed(DTContext context)
        {
            CreateTestRecord(context);
        }

        public void CreateTestRecord(DTContext context)
        {
            var firstEntry = context.CurrencyInformations.ToList();
            if (firstEntry.Count == 0)
            {
                context.CurrencyInformations.AddOrUpdate(newTestEntry => newTestEntry.Id, new CurrencyInfo()
                {

                });
            }
        }
    }
}