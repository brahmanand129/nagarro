namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModuleMsts",
                c => new
                    {
                        pk_moduleid = c.Int(nullable: false, identity: true),
                        ModuleName = c.String(),
                        ModuleDesc = c.String(),
                        ActionName = c.String(),
                        ControllerName = c.String(),
                        AreaName = c.String(),
                        Imgurl = c.String(),
                        IsActive = c.String(),
                    })
                .PrimaryKey(t => t.pk_moduleid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ModuleMsts");
        }
    }
}
