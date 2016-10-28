namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFilmComputed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "FilmCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "FilmCode", c => c.String(nullable: false));
        }
    }
}
