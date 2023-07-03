namespace book_reading_event.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class displaymodule : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ModuleMsts", "IsActive", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ModuleMsts", "IsActive", c => c.String());
        }
    }
}
