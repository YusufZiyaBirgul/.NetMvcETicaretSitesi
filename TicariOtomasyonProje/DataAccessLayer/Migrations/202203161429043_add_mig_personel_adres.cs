namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_personel_adres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personnels", "PAddressID", "dbo.PersonnelAddresses");
            DropForeignKey("dbo.Personnels", "Personnel_PersonelID", "dbo.Personnels");
            DropIndex("dbo.Personnels", new[] { "PAddressID" });
            DropIndex("dbo.Personnels", new[] { "Personnel_PersonelID" });
            DropColumn("dbo.Personnels", "PAddressID");
            DropColumn("dbo.Personnels", "Personnel_PersonelID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnels", "Personnel_PersonelID", c => c.Int());
            AddColumn("dbo.Personnels", "PAddressID", c => c.Int(nullable: false));
            CreateIndex("dbo.Personnels", "Personnel_PersonelID");
            CreateIndex("dbo.Personnels", "PAddressID");
            AddForeignKey("dbo.Personnels", "Personnel_PersonelID", "dbo.Personnels", "PersonelID");
            AddForeignKey("dbo.Personnels", "PAddressID", "dbo.PersonnelAddresses", "PAddressID", cascadeDelete: true);
        }
    }
}
