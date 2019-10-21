namespace ToDoNetFrameworkBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descriptio = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskToDoes");
        }
    }
}
