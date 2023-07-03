namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addusername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventMasters", "username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventMasters", "username");
        }
    }
}
