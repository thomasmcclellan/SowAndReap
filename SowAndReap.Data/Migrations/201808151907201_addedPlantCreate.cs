namespace SowAndReap.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPlantCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plant", "WillLive_WillLive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Plant", "WillLive_LeafColor", c => c.String());
            AddColumn("dbo.Plant", "WillLive_StalkStrenth", c => c.String());
            AddColumn("dbo.Plant", "WillLive_BearingFruit", c => c.Boolean(nullable: false));
            DropColumn("dbo.Plant", "PlantHealth_WillLive");
            DropColumn("dbo.Plant", "PlantHealth_LeafColor");
            DropColumn("dbo.Plant", "PlantHealth_StalkStrenth");
            DropColumn("dbo.Plant", "PlantHealth_BearingFruit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plant", "PlantHealth_BearingFruit", c => c.Boolean(nullable: false));
            AddColumn("dbo.Plant", "PlantHealth_StalkStrenth", c => c.String());
            AddColumn("dbo.Plant", "PlantHealth_LeafColor", c => c.String());
            AddColumn("dbo.Plant", "PlantHealth_WillLive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Plant", "WillLive_BearingFruit");
            DropColumn("dbo.Plant", "WillLive_StalkStrenth");
            DropColumn("dbo.Plant", "WillLive_LeafColor");
            DropColumn("dbo.Plant", "WillLive_WillLive");
        }
    }
}
