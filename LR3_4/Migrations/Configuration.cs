namespace LR3_4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LR3_4.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<LR3_4.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LR3_4.Models.ApplicationDbContext";
        }

        protected override void Seed(LR3_4.Models.ApplicationDbContext context)
        {
            Category cn = new Category("Samsung");

            Category cn2 = new Category("LG");
            context.Phones.Add(new Phone { Path = "https://images.ua.prom.st/1982301158_smarfon-samsung-galaxy.jpg", Mark = "Phone11", Price = "12000", CN1 = cn });
            context.Phones.Add(new Phone { Path = "https://i.allo.ua/media/catalog/product/cache/1/image/425x295/602f0fa2c1f0d1ba5e241f914e856ff9/s/a/samsung_galaxy_j6_black_6_1.jpg", Mark = "A30S", Price = "12000", CN1 = cn2 });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
