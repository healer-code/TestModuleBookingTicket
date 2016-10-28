namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCreateDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cinemas", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Cinemas", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.FilmSessions", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.FilmSessions", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Films", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Films", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Statuss", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Statuss", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.RoomFilms", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.RoomFilms", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatLists", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatLists", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatTables", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatTables", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatTypes", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.SeatTypes", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.TimeSessions", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.TimeSessions", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeSessions", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TimeSessions", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatTypes", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatTypes", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatTables", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatTables", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatLists", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SeatLists", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RoomFilms", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RoomFilms", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Statuss", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Statuss", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Films", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Films", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FilmSessions", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FilmSessions", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cinemas", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cinemas", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
