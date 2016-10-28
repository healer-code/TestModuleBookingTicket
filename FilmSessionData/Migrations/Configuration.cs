namespace FilmSessionData.Migrations
{
    using FilmSessionModel.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FilmSessionCommon.BookingTime;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmSessionData.TestCodeFirstEntityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FilmSessionData.TestCodeFirstEntityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //CreateDataBookingTimeChildComponent(context);
            //CreateDataBookingTimeMainComponent(context);
        }

        private void CreateDataBookingTimeChildComponent(TestCodeFirstEntityDbContext context)
        {
            //Status
            context.Statuss.Add(new Status() { StatusID = "NOT", StatusName = "Chưa hoạt động" });
            //Cinema 
            context.Cinemas.Add(new Cinema() { CinemaName = "Mega Cao Thắng", CinemaStatus = "NOT" });
            //Film
            context.Films.Add(new Film() { FilmPrefix = "FLM", FilmName = "Nếu ốc sên có tình yêu", FilmDuration = 120, FilmStatus = "NOT" });
            context.Films.Add(new Film() { FilmPrefix = "FLM", FilmName = "Bên nhau trọn đời", FilmDuration = 100, FilmStatus = "NOT" });
            //Room
            context.RoomFilms.Add(new RoomFilm() { RoomFilmPrefix = "ROO", RoomFilmName = "6-OPPO", RoomAmountSeat = 6, RoomFilmStatus = "NOT" });
            context.RoomFilms.Add(new RoomFilm() { RoomFilmPrefix = "ROO", RoomFilmName = "ROX", RoomAmountSeat = 6, RoomFilmStatus = "NOT" });
        }
        private void CreateDataBookingTimeMainComponent(TestCodeFirstEntityDbContext context)
        {
            BookingTimeHelpers temp = new BookingTimeHelpers();
            var bookingPlan = temp.ConvertBookingTimeToJson(temp.GenerateSampleData());
            context.FilmSessions.Add(new FilmSession() {FilmID = 1,CinemaID = 1, FilmCalendar = bookingPlan, FilmSessionStatus ="NOT" });
        }
    }
}
