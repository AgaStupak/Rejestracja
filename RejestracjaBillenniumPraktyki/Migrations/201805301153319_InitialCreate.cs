namespace RejestracjaBillenniumPraktyki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        FirstLastName = c.String(nullable: false),
                        Reasons = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
