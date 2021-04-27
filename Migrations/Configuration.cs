namespace TruYumMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TruYumMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TruYumMVC.Models.TruYumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TruYumMVC.Models.TruYumContext context)
        {
            context.Categories.AddOrUpdate(e => e.Name,
                new Models.Category { Name = "Main-Course" },
                new Models.Category { Name = "Starters" },
                new Models.Category { Name = "Snack" }
            );
        }
    }
}
