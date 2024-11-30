namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedBirthdayColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
        }
    }
}
