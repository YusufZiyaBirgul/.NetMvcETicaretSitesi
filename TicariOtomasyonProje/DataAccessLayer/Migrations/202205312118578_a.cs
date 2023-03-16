namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Product_BookID", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Product_BookID" });
            RenameColumn(table: "dbo.Orders", name: "Product_BookID", newName: "BookID");
            AlterColumn("dbo.Orders", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "BookID");
            AddForeignKey("dbo.Orders", "BookID", "dbo.Books", "BookID", cascadeDelete: true);
            DropColumn("dbo.Orders", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProductId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "BookID", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookID" });
            AlterColumn("dbo.Orders", "BookID", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "BookID", newName: "Product_BookID");
            CreateIndex("dbo.Orders", "Product_BookID");
            AddForeignKey("dbo.Orders", "Product_BookID", "dbo.Books", "BookID");
        }
    }
}
