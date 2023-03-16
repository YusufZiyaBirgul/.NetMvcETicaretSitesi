namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_book : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Books", "PublisherID", "dbo.Publishers");
            DropForeignKey("dbo.Books", "PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Books", "SaleID", "dbo.Sales");
            DropIndex("dbo.Books", new[] { "PurchaseID" });
            DropIndex("dbo.Books", new[] { "SaleID" });
            DropIndex("dbo.Books", new[] { "PublisherID" });
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropColumn("dbo.Books", "PurchaseID");
            DropColumn("dbo.Books", "SaleID");
            DropColumn("dbo.Books", "PublisherID");
            DropColumn("dbo.Books", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "PublisherID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "SaleID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "PurchaseID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "CategoryID");
            CreateIndex("dbo.Books", "PublisherID");
            CreateIndex("dbo.Books", "SaleID");
            CreateIndex("dbo.Books", "PurchaseID");
            AddForeignKey("dbo.Books", "SaleID", "dbo.Sales", "SaleID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "PurchaseID", "dbo.Purchases", "PurchaseID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "PublisherID", "dbo.Publishers", "PublisherID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
    }
}
