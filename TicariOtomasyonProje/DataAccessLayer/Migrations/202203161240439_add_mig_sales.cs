namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_sales : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "Sale_SaleID", "dbo.Sales");
            DropIndex("dbo.Sales", new[] { "Sale_SaleID" });
            DropColumn("dbo.Sales", "Sale_SaleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Sale_SaleID", c => c.Int());
            CreateIndex("dbo.Sales", "Sale_SaleID");
            AddForeignKey("dbo.Sales", "Sale_SaleID", "dbo.Sales", "SaleID");
        }
    }
}
