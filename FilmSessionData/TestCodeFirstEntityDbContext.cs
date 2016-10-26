using System;
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
        public DbSet<Status> Statuss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
