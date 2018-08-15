namespace SowAndReap.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedControllers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plant", "PlantHealth_WillLive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Plant", "PlantHealth_LeafColor", c => c.String());
            AddColumn("dbo.Plant", "PlantHealth_StalkStrenth", c => c.String());
            AddColumn("dbo.Plant", "PlantHealth_BearingFruit", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plant", "PlantHealth_BearingFruit");
            DropColumn("dbo.Plant", "PlantHealth_StalkStrenth");
            DropColumn("dbo.Plant", "PlantHealth_LeafColor");
            DropColumn("dbo.Plant", "PlantHealth_WillLive");
        }
    }
}
