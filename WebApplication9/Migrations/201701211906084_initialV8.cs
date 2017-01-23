namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialV8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfileInfoes", "AspNetUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfileInfoes", "AspNetUserId", c => c.Guid(nullable: false));
        }
    }
}
