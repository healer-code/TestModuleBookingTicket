namespace FilmSessionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        FilmPrefix = c.String(nullable: false, maxLength: 3),
                        FilmCode = c.String(nullable: false),
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
                .ForeignKey("dbo.Statuss", t => t.FilmStatus, cascadeDelete: true)
                .Index(t => t.FilmStatus);
            Sql("Alter table dbo.Films drop column FilmCode");
            Sql("Alter table dbo.Films ADD FilmCode AS FilmPrefix + ' ' + Convert(Varchar(MAX),FilmID)");
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
                "dbo.FilmSessions",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        FilmSessionStatus = c.String(nullable: false, maxLength: 3),
                        FilmCalendar = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.FilmID)
                .ForeignKey("dbo.Statuss", t => t.FilmSessionStatus, cascadeDelete: true)
                .Index(t => t.FilmSessionStatus);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmSessions", "FilmSessionStatus", "dbo.Statuss");
            DropForeignKey("dbo.Films", "FilmStatus", "dbo.Statuss");
            DropIndex("dbo.FilmSessions", new[] { "FilmSessionStatus" });
            DropIndex("dbo.Films", new[] { "FilmStatus" });
            DropTable("dbo.FilmSessions");
            DropTable("dbo.Statuss");
            DropTable("dbo.Films");
        }
    }
}
