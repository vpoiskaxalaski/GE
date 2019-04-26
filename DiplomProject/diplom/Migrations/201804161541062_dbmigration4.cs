namespace diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbmigration4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ImagesGalleries", name: "Post_Id", newName: "PostId");
            RenameIndex(table: "dbo.ImagesGalleries", name: "IX_Post_Id", newName: "IX_PostId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ImagesGalleries", name: "IX_PostId", newName: "IX_Post_Id");
            RenameColumn(table: "dbo.ImagesGalleries", name: "PostId", newName: "Post_Id");
        }
    }
}
