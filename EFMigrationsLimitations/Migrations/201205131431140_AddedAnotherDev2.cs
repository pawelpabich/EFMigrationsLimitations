namespace EFMigrationsLimitations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnotherDev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Items", "AnotherDev", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Items", "AnotherDev");
        }
    }
}
