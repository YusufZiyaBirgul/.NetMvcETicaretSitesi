namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_book3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Books", "BookName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Books", "PublisherName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Books", "Category", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Category", c => c.String());
            AlterColumn("dbo.Books", "PublisherName", c => c.String());
            AlterColumn("dbo.Books", "BookName", c => c.String());
            DropColumn("dbo.Books", "BookImage");
        }
    }
}
