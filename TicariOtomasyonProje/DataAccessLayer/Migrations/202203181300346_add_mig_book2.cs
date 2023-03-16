namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_book2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PurchasePrice", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "SalePrice", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "PublisherName", c => c.String());
            AddColumn("dbo.Books", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Category");
            DropColumn("dbo.Books", "PublisherName");
            DropColumn("dbo.Books", "SalePrice");
            DropColumn("dbo.Books", "PurchasePrice");
        }
    }
}
