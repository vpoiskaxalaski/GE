namespace diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbmigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImagesGalleries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ImageData = c.Binary(),
                        PostId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        CityId = c.String(maxLength: 128),
                        DateCreatePost = c.String(),
                        UserId = c.String(maxLength: 128),
                        SubcategoryId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Subcategories", t => t.SubcategoryId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CityId)
                .Index(t => t.UserId)
                .Index(t => t.SubcategoryId);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Earned = c.Int(),
                        Spent = c.Int(),
                        Date = c.String(),
                        PointId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Points", t => t.PointId)
                .Index(t => t.PointId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PostId = c.String(maxLength: 128),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.PostId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Points", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Operations", "PointId", "dbo.Points");
            DropForeignKey("dbo.Posts", "SubcategoryId", "dbo.Subcategories");
            DropForeignKey("dbo.ImagesGalleries", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CityId", "dbo.Cities");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "PostId" });
            DropIndex("dbo.Operations", new[] { "PointId" });
            DropIndex("dbo.Points", new[] { "Id" });
            DropIndex("dbo.Posts", new[] { "SubcategoryId" });
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropIndex("dbo.Posts", new[] { "CityId" });
            DropIndex("dbo.ImagesGalleries", new[] { "PostId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Operations");
            DropTable("dbo.Points");
            DropTable("dbo.Posts");
            DropTable("dbo.ImagesGalleries");
        }
    }
}
