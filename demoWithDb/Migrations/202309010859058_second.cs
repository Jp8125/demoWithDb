namespace demoWithDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String());
            DropColumn("dbo.Students", "Genter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Genter", c => c.String());
            DropColumn("dbo.Students", "Gender");
        }
    }
}
