namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Pay As You Go' WHERE Id = '1'");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Monthly' WHERE Id = '2'");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Yearly' WHERE Id = '3'");
        }
        
        public override void Down()
        {
        }
    }
}
