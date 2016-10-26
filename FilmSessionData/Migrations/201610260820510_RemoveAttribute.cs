namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAttribute : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "TestAttribute");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "TestAttribute", c => c.String());
        }
    }
}
