﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FilmSessionModel.Models;

namespace FilmSessionData
{
    public class TestCodeFirstEntityDbContext:DbContext
    {
        public TestCodeFirstEntityDbContext():base("TestCodeFirstEntity")
        {
            //parents table not include child table foreign key
            this.Configuration.LazyLoadingEnabled = false;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
