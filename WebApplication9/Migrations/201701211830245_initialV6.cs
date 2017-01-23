namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialV6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfileInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        ApplicationUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserProfileInfo_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "UserProfileInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "UserProfileInfo_Id" });
            DropColumn("dbo.AspNetUsers", "UserProfileInfo_Id");
            DropTable("dbo.UserProfileInfoes");
        }
    }
}
