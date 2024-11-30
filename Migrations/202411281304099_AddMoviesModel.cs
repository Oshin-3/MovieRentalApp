namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleasedDate = c.DateTime(nullable: false),
                        LastUpdatedDate = c.DateTime(),
                        NoOfItems = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        Genres_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genres_Id)
                .Index(t => t.Genres_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
