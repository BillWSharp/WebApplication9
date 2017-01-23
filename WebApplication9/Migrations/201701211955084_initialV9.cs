namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialV9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "UserProfileInfo_Id" });
            AddColumn("dbo.AspNetUsers", "Firstname", c => c.String());
            AddColumn("dbo.AspNetUsers", "Lastname", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserProfileInfo_Id");
            DropTable("dbo.UserProfileInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProfileInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserProfileInfo_Id", c => c.Int());
            DropColumn("dbo.AspNetUsers", "Lastname");
            DropColumn("dbo.AspNetUsers", "Firstname");
            CreateIndex("dbo.AspNetUsers", "UserProfileInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes", "Id");
        }
    }
}
