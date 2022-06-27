namespace Thuchanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hoc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.hocsinhs", "address", c => c.String(maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.hocsinhs", "address", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
