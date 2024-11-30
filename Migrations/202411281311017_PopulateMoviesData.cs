namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, ReleasedDate, LastUpdatedDate, NoOfItems, Genres_Id) VALUES ('Hangover', '2006-03-11', GETDATE(), 4, 2)");
            Sql("INSERT INTO Movies (Title, ReleasedDate, LastUpdatedDate, NoOfItems, Genres_Id) VALUES ('Die Hard', '1999-03-27', GETDATE(), 10, 1)");
            Sql("INSERT INTO Movies (Title, ReleasedDate, LastUpdatedDate, NoOfItems, Genres_Id) VALUES ('Seven', '2003-02-12', GETDATE(), 4, 4)");
            Sql("INSERT INTO Movies (Title, ReleasedDate, LastUpdatedDate, NoOfItems, Genres_Id) VALUES ('Titanic', '1997-04-19', GETDATE(), 7, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
