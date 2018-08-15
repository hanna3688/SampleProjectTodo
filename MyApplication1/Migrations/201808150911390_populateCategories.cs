namespace MyApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Reading')");
            Sql("INSERT INTO Categories (Name) VALUES ('Research')");
            Sql("INSERT INTO Categories (Name) VALUES ('Assignment')");
            Sql("INSERT INTO Categories (Name) VALUES ('Test')");
            Sql("INSERT INTO Categories (Name) VALUES ('Revision')");
            Sql("INSERT INTO Categories (Name) VALUES ('Daily')");
            Sql("INSERT INTO Categories (Name) VALUES ('Work')");
            Sql("INSERT INTO Categories (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
