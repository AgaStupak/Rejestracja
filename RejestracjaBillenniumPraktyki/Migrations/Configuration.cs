namespace RejestracjaBillenniumPraktyki.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RejestracjaBillenniumPraktyki.DAL.RegistrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RejestracjaBillenniumPraktyki.DAL.RegistrationContext";
        }

        protected override void Seed(RejestracjaBillenniumPraktyki.DAL.RegistrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
