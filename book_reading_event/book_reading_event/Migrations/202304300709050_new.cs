namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Event1", "Date");
            DropColumn("dbo.Event1", "Location");
            DropColumn("dbo.Event1", "StartTime");
            DropColumn("dbo.Event1", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Event1", "Type", c => c.String());
            AddColumn("dbo.Event1", "StartTime", c => c.String());
            AddColumn("dbo.Event1", "Location", c => c.String());
            AddColumn("dbo.Event1", "Date", c => c.String());
        }
    }
}
