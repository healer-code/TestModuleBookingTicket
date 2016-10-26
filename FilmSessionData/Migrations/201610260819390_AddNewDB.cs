namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "TestAttribute", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "TestAttribute");
        }
    }
}
