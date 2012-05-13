namespace EFMigrationsLimitations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnotherDev : DbMigration
    {
        public override void Up()
        {
            AddColumn("Items", "AnotherDev", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Items", "AnotherDev");
        }
    }
}
