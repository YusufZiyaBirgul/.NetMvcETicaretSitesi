namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_fk_mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublisherID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "PublisherID");
            CreateIndex("dbo.Books", "CategoryID");
            AddForeignKey("dbo.Books", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "PublisherID", "dbo.Publishers", "PublisherID", cascadeDelete: true);
            DropColumn("dbo.Books", "PublisherName");
            DropColumn("dbo.Books", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Category", c => c.String(maxLength: 30));
            AddColumn("dbo.Books", "PublisherName", c => c.String(maxLength: 30));
            DropForeignKey("dbo.Books", "PublisherID", "dbo.Publishers");
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropIndex("dbo.Books", new[] { "PublisherID" });
            DropColumn("dbo.Books", "CategoryID");
            DropColumn("dbo.Books", "PublisherID");
        }
    }
}
