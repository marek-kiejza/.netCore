namespace Cora.Classes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cora.Model.BoardContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cora.Model.BoardContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(new Category[] {
                new Category
                {
                    CategoryName = "Category A"
                },
                new Category
                {
                    CategoryName = "Category B"
                },
                new Category
                {
                    CategoryName = "Category C"
                }
            });//end of creating categories
        }
    }
}
