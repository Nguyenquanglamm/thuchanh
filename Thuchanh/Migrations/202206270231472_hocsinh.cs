namespace Thuchanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hocsinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.hocsinhs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.hocsinhs");
        }
    }
}
