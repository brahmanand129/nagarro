namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fk_id = c.Int(nullable: false),
                        title = c.String(),
                        Date = c.String(),
                        Location = c.String(),
                        StartTime = c.String(),
                        Type = c.String(),
                        Duration = c.Int(nullable: false),
                        Description = c.String(),
                        Details = c.String(),
                        Invite = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventMasters");
        }
    }
}
