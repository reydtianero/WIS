namespace WarehouseInventory.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PermissionSets",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IsAdmin = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Password = c.String(),
                    PermissionSetID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.PermissionSets");
        }
    }
}