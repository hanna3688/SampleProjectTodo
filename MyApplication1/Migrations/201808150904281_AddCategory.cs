namespace MyApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Todoes", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Todoes", "CategoryId");
            AddForeignKey("dbo.Todoes", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Todoes", new[] { "CategoryId" });
            DropColumn("dbo.Todoes", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
