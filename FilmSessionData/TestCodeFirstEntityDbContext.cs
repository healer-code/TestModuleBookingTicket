using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FilmSessionModel.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FilmSessionData
{
    public class TestCodeFirstEntityDbContext: IdentityDbContext<ApplicationUser>
    {
        public TestCodeFirstEntityDbContext():base("TestCodeFirstEntity")
        {
            //parents table not include child table foreign key
            this.Configuration.LazyLoadingEnabled = false;
        }
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                throw new DbEntityValidationException(errorMessages);
            }
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<FilmSession> FilmSessions { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<RoomFilm> RoomFilms { get; set; }
        public DbSet<SeatList> SeatLists { get; set; }
        public DbSet<SeatTable> SeatTables { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<TimeSession> TimeSessions { get; set; }
        public DbSet<Status> Statuss { get; set; }

        public static TestCodeFirstEntityDbContext Create()
        {
            return new TestCodeFirstEntityDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmSessions)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cinema>()
                .HasMany(n => n.FilmSessions)
                .WithRequired(n => n.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatType>()
                .HasMany(e => e.SeatLists)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatTable>()
                .HasMany(e => e.SeatLists)
                .WithRequired(e => e.SeatTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomFilm>()
                .HasMany(e => e.SeatTables)
                .WithRequired(e => e.RoomFilm)
                .WillCascadeOnDelete(false);

            //status
            modelBuilder.Entity<Status>()
                .HasMany(e => e.Cinemas)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.FilmSessions)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.RoomFilms)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatLists)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatTables)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatTypes)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TimeSessions)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            //Identity 
            modelBuilder.Entity<IdentityUserRole>().HasKey(e => e.UserId);
            modelBuilder.Entity<IdentityUserLogin>().HasKey(e => e.UserId);
        }
    }
}
