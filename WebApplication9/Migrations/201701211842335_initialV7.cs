namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialV7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfileInfoes", "AspNetUserId", c => c.Guid(nullable: false));
            DropColumn("dbo.UserProfileInfoes", "ApplicationUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfileInfoes", "ApplicationUserId", c => c.Guid(nullable: false));
            DropColumn("dbo.UserProfileInfoes", "AspNetUserId");
        }
    }
}
