namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventMasters", "Event_Type", c => c.Int(nullable: false));
            DropColumn("dbo.EventMasters", "fk_id");
            DropColumn("dbo.EventMasters", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventMasters", "Type", c => c.String());
            AddColumn("dbo.EventMasters", "fk_id", c => c.Int(nullable: false));
            DropColumn("dbo.EventMasters", "Event_Type");
        }
    }
}
