namespace EFMigrationsLimitations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("Items", "Master", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Items", "Master");
        }
    }
}
