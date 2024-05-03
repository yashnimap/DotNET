namespace CodeFirstwithExitingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameLevelToPriceinCourseTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Level", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "Level");
        }
    }
}
