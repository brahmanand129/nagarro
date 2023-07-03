namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new23 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EventMasters", "StartTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventMasters", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
