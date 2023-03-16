namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderNo = c.Int(nullable: false),
                        OrderStatus = c.String(maxLength: 20),
                        ProductId = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        Product_BookID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Product_BookID)
                .Index(t => t.CustomerID)
                .Index(t => t.Product_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Product_BookID", "dbo.Books");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Product_BookID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.Orders");
        }
    }
}
