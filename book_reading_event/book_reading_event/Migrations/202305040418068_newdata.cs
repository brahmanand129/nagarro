namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventMasters", "Title", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.EventMasters", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EventMasters", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.EventMasters", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventMasters", "StartTime", c => c.String());
            AlterColumn("dbo.EventMasters", "Location", c => c.String());
            AlterColumn("dbo.EventMasters", "Date", c => c.String());
            AlterColumn("dbo.EventMasters", "Title", c => c.String());
        }
    }
}
