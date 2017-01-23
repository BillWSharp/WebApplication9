namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialV10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Firstname", c => c.String(maxLength: 40));
            AlterColumn("dbo.AspNetUsers", "Lastname", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Lastname", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Firstname", c => c.String());
        }
    }
}
