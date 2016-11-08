namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicationUsers", "Birthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicationUsers", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
