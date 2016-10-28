namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFilmSessionColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.FilmSessions", name: "FilmSessionID", newName: "FilmID");
            RenameIndex(table: "dbo.FilmSessions", name: "IX_FilmSessionID", newName: "IX_FilmID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.FilmSessions", name: "IX_FilmID", newName: "IX_FilmSessionID");
            RenameColumn(table: "dbo.FilmSessions", name: "FilmID", newName: "FilmSessionID");
        }
    }
}
