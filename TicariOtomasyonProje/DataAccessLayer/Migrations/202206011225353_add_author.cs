namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_author : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(maxLength: 30),
                        AuthorSurname = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            AddColumn("dbo.Books", "AuthorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropColumn("dbo.Books", "AuthorID");
            DropTable("dbo.Authors");
        }
    }
}
