namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using FilmSessionCommon.BookingTime;
    using FilmSessionCommon.SqlScriptCodeFirst;

    public partial class CustomAutoIndexFunction : DbMigration
    {
        public override void Up()
        {
            ScriptGenerate scriptGenerate = new ScriptGenerate();
            Sql(scriptGenerate.AlterAutoIndexTable("Films", "FilmCode", "FilmPrefix", "FilmID"));
            Sql(scriptGenerate.AlterAutoIndexTable("RoomFilms", "RoomFilmCode", "RoomFilmPrefix", "RoomFilmID"));
            Sql(scriptGenerate.AlterAutoIndexTable("SeatLists", "SeatCode", "SeatPrefix", "SeatID"));
            Sql(scriptGenerate.AlterAutoIndexTable("SeatTypes", "SeatTypeCode", "SeatTypePrefix", "SeatTypeID"));
        }
        
        public override void Down()
        {
        }
    }
}
