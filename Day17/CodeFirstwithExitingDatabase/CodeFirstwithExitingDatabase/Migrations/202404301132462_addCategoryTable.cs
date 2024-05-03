namespace CodeFirstwithExitingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories VALUES(1,'Dot net Developer')");
            Sql("INSERT INTO Categories VALUES(2, 'Java Developer')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
