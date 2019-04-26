namespace diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbmigration3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ImagesGalleries", name: "PostId", newName: "Post_Id");
            RenameIndex(table: "dbo.ImagesGalleries", name: "IX_PostId", newName: "IX_Post_Id");
            AddColumn("dbo.ImagesGalleries", "Title", c => c.String());
            AddColumn("dbo.ImagesGalleries", "Name", c => c.String());
            DropColumn("dbo.ImagesGalleries", "ImageData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ImagesGalleries", "ImageData", c => c.Binary());
            DropColumn("dbo.ImagesGalleries", "Name");
            DropColumn("dbo.ImagesGalleries", "Title");
            RenameIndex(table: "dbo.ImagesGalleries", name: "IX_Post_Id", newName: "IX_PostId");
            RenameColumn(table: "dbo.ImagesGalleries", name: "Post_Id", newName: "PostId");
        }
    }
}
