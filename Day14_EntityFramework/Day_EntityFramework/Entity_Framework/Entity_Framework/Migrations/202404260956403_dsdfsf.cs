namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsdfsf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Created");
        }
    }
}
