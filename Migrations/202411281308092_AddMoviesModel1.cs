namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
        }
    }
}
