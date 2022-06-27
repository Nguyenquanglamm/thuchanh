namespace Thuchanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hoc1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.hocsinhs", "address", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.hocsinhs", "address");
        }
    }
}
