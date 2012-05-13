namespace EFMigrationsLimitations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Items");
        }
    }
}
