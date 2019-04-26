namespace diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbmigration5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Status");
        }
    }
}
