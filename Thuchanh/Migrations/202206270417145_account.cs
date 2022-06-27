namespace Thuchanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 128),
                        passWord = c.String(),
                    })
                .PrimaryKey(t => t.userName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
