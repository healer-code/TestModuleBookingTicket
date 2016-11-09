namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
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
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        IndexStaff = c.Int(nullable: false, identity: true),
                        Point = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IndexStaff);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        IndexStaff = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.IndexStaff);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        Address = c.String(),
                        Birthday = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        Customer_IndexStaff = c.Int(),
                        Staff_IndexStaff = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_IndexStaff)
                .ForeignKey("dbo.Staffs", t => t.Staff_IndexStaff)
                .Index(t => t.Customer_IndexStaff)
                .Index(t => t.Staff_IndexStaff);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUsers", "Staff_IndexStaff", "dbo.Staffs");
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUsers", "Customer_IndexStaff", "dbo.Customers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
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
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUsers", new[] { "Staff_IndexStaff" });
            DropIndex("dbo.ApplicationUsers", new[] { "Customer_IndexStaff" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
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
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Staffs");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.Customers");
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
