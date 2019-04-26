namespace diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbmigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "VideoId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "VideoId");
            AddForeignKey("dbo.Posts", "VideoId", "dbo.Videos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "VideoId", "dbo.Videos");
            DropIndex("dbo.Posts", new[] { "VideoId" });
            DropColumn("dbo.Posts", "VideoId");
            DropTable("dbo.Videos");
        }
    }
}
