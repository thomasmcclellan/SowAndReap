namespace SowAndReap.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anotherAttempt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Crop",
                c => new
                    {
                        CropID = c.Int(nullable: false, identity: true),
                        PlantID = c.Int(nullable: false),
                        MaterialID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CropID)
                .ForeignKey("dbo.Material", t => t.MaterialID, cascadeDelete: true)
                .ForeignKey("dbo.Plant", t => t.PlantID, cascadeDelete: true)
                .Index(t => t.PlantID)
                .Index(t => t.MaterialID);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        MaterialID = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(nullable: false),
                        MaterialCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaterialDOP = c.DateTimeOffset(nullable: false, precision: 7),
                        MaterialFrequency = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialID);
            
            CreateTable(
                "dbo.Plant",
                c => new
                    {
                        PlantID = c.Int(nullable: false, identity: true),
                        OwnerID = c.Guid(nullable: false),
                        PlantName = c.String(nullable: false),
                        SowStartDate = c.DateTime(nullable: false),
                        SowEndDate = c.DateTime(nullable: false),
                        ReapStartDate = c.DateTime(nullable: false),
                        ReapEndDate = c.DateTime(nullable: false),
                        SpaceNeeds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlantID);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Crop", "PlantID", "dbo.Plant");
            DropForeignKey("dbo.Crop", "MaterialID", "dbo.Material");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Crop", new[] { "MaterialID" });
            DropIndex("dbo.Crop", new[] { "PlantID" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Plant");
            DropTable("dbo.Material");
            DropTable("dbo.Crop");
        }
    }
}
