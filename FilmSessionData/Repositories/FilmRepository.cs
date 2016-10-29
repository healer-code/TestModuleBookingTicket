using System;
using System.Collections.Generic;
using System.Linq;
using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;
using System.Data.Entity;

namespace FilmSessionData.Repositories
{
    public interface IFilmRepository:IRepository<Film>
    {
        FilmSession GetFullFilmDetail(int id);
        Film GetFilmWithSessionTime(int id);
    }
    public class FilmRepository: RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

        public Film GetFilmWithSessionTime(int id)
        {
            return this.DbContext.Films.Include(c => c.FilmSessions).Where(n => n.FilmID == id).FirstOrDefault();
        }

        public FilmSession GetFullFilmDetail(int id)
        {
            return this.DbContext.FilmSessions.Where(n => n.FilmID == id).OrderByDescending(n => n.FilmID).FirstOrDefault();
        }
    }
}
