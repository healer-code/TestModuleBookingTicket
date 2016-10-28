namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialFirstDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        CinemaID = c.Int(nullable: false, identity: true),
                        CinemaName = c.String(nullable: false, maxLength: 100),
                        CinemaStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.CinemaID)
                .ForeignKey("dbo.Statuss", t => t.CinemaStatus)
                .Index(t => t.CinemaStatus);
            
            CreateTable(
                "dbo.FilmSessions",
                c => new
                    {
                        FilmID = c.Int(nullable: false),
                        CinemaID = c.Int(nullable: false),
                        FilmSessionStatus = c.String(nullable: false, maxLength: 3),
                        FilmCalendar = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => new { t.FilmID, t.CinemaID })
                .ForeignKey("dbo.Films", t => t.FilmID)
                .ForeignKey("dbo.Statuss", t => t.FilmSessionStatus)
                .ForeignKey("dbo.Cinemas", t => t.CinemaID)
                .Index(t => t.FilmID)
                .Index(t => t.CinemaID)
                .Index(t => t.FilmSessionStatus);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        FilmPrefix = c.String(nullable: false, maxLength: 3),
                        FilmCode = c.String(),
                        FilmName = c.String(nullable: false, maxLength: 100),
                        FilmDuration = c.Int(nullable: false),
                        FilmStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.FilmID)
                .ForeignKey("dbo.Statuss", t => t.FilmStatus)
                .Index(t => t.FilmStatus);

            CreateTable(
                "dbo.Statuss",
                c => new
                    {
                        StatusID = c.String(nullable: false, maxLength: 3),
                        StatusName = c.String(maxLength: 100),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.RoomFilms",
                c => new
                    {
                        RoomFilmID = c.Int(nullable: false, identity: true),
                        RoomFilmPrefix = c.String(nullable: false, maxLength: 3),
                        RoomFilmCode = c.String(),
                        RoomFilmName = c.String(nullable: false),
                        RoomAmountSeat = c.Int(nullable: false),
                        RoomFilmStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.RoomFilmID)
                .ForeignKey("dbo.Statuss", t => t.RoomFilmStatus)
                .Index(t => t.RoomFilmStatus);
            
            CreateTable(
                "dbo.SeatTables",
                c => new
                    {
                        SeatTableID = c.Int(nullable: false, identity: true),
                        SeatTableMap = c.String(nullable: false),
                        SeatTableRoom = c.Int(nullable: false),
                        SeatTableWidth = c.Int(nullable: false),
                        SeatTableHeight = c.Int(nullable: false),
                        SeatTableStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.SeatTableID)
                .ForeignKey("dbo.RoomFilms", t => t.SeatTableRoom)
                .ForeignKey("dbo.Statuss", t => t.SeatTableStatus)
                .Index(t => t.SeatTableRoom)
                .Index(t => t.SeatTableStatus);
            
            CreateTable(
                "dbo.SeatLists",
                c => new
                    {
                        SeatID = c.Int(nullable: false, identity: true),
                        SeatPrefix = c.String(nullable: false, maxLength: 3),
                        SeatCode = c.String(),
                        SeatListTable = c.Int(nullable: false),
                        SeatTypeID = c.Int(nullable: false),
                        SeatStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.SeatID)
                .ForeignKey("dbo.SeatTypes", t => t.SeatTypeID)
                .ForeignKey("dbo.SeatTables", t => t.SeatListTable)
                .ForeignKey("dbo.Statuss", t => t.SeatStatus)
                .Index(t => t.SeatListTable)
                .Index(t => t.SeatTypeID)
                .Index(t => t.SeatStatus);
            
            CreateTable(
                "dbo.SeatTypes",
                c => new
                    {
                        SeatTypeID = c.Int(nullable: false, identity: true),
                        SeatTypePrefix = c.String(nullable: false, maxLength: 3),
                        SeatTypeCode = c.String(),
                        SeatTypeName = c.String(nullable: false, maxLength: 100),
                        SeatTypeStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.SeatTypeID)
                .ForeignKey("dbo.Statuss", t => t.SeatTypeStatus)
                .Index(t => t.SeatTypeStatus);
            
            CreateTable(
                "dbo.TimeSessions",
                c => new
                    {
                        TimeSessionID = c.Int(nullable: false, identity: true),
                        StartTime = c.Time(nullable: false, precision: 7),
                        TimeSessionStatus = c.String(nullable: false, maxLength: 3),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.TimeSessionID)
                .ForeignKey("dbo.Statuss", t => t.TimeSessionStatus)
                .Index(t => t.TimeSessionStatus);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmSessions", "CinemaID", "dbo.Cinemas");
            DropForeignKey("dbo.TimeSessions", "TimeSessionStatus", "dbo.Statuss");
            DropForeignKey("dbo.SeatTypes", "SeatTypeStatus", "dbo.Statuss");
            DropForeignKey("dbo.SeatTables", "SeatTableStatus", "dbo.Statuss");
            DropForeignKey("dbo.SeatLists", "SeatStatus", "dbo.Statuss");
            DropForeignKey("dbo.RoomFilms", "RoomFilmStatus", "dbo.Statuss");
            DropForeignKey("dbo.SeatTables", "SeatTableRoom", "dbo.RoomFilms");
            DropForeignKey("dbo.SeatLists", "SeatListTable", "dbo.SeatTables");
            DropForeignKey("dbo.SeatLists", "SeatTypeID", "dbo.SeatTypes");
            DropForeignKey("dbo.FilmSessions", "FilmSessionStatus", "dbo.Statuss");
            DropForeignKey("dbo.Films", "FilmStatus", "dbo.Statuss");
            DropForeignKey("dbo.Cinemas", "CinemaStatus", "dbo.Statuss");
            DropForeignKey("dbo.FilmSessions", "FilmID", "dbo.Films");
            DropIndex("dbo.TimeSessions", new[] { "TimeSessionStatus" });
            DropIndex("dbo.SeatTypes", new[] { "SeatTypeStatus" });
            DropIndex("dbo.SeatLists", new[] { "SeatStatus" });
            DropIndex("dbo.SeatLists", new[] { "SeatTypeID" });
            DropIndex("dbo.SeatLists", new[] { "SeatListTable" });
            DropIndex("dbo.SeatTables", new[] { "SeatTableStatus" });
            DropIndex("dbo.SeatTables", new[] { "SeatTableRoom" });
            DropIndex("dbo.RoomFilms", new[] { "RoomFilmStatus" });
            DropIndex("dbo.Films", new[] { "FilmStatus" });
            DropIndex("dbo.FilmSessions", new[] { "FilmSessionStatus" });
            DropIndex("dbo.FilmSessions", new[] { "CinemaID" });
            DropIndex("dbo.FilmSessions", new[] { "FilmID" });
            DropIndex("dbo.Cinemas", new[] { "CinemaStatus" });
            DropTable("dbo.TimeSessions");
            DropTable("dbo.SeatTypes");
            DropTable("dbo.SeatLists");
            DropTable("dbo.SeatTables");
            DropTable("dbo.RoomFilms");
            DropTable("dbo.Statuss");
            DropTable("dbo.Films");
            DropTable("dbo.FilmSessions");
            DropTable("dbo.Cinemas");
        }
    }
}
