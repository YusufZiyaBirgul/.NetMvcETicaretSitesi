namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer_adress_mig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CustomerAddress_CAddressID", "dbo.CustomerAddresses");
            DropIndex("dbo.Customers", new[] { "CustomerAddress_CAddressID" });
            DropColumn("dbo.Customers", "CustomerAddress_CAddressID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerAddress_CAddressID", c => c.Int());
            CreateIndex("dbo.Customers", "CustomerAddress_CAddressID");
            AddForeignKey("dbo.Customers", "CustomerAddress_CAddressID", "dbo.CustomerAddresses", "CAddressID");
        }
    }
}
