using System.Collections.Generic;
using System.Linq;
using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;

namespace FilmSessionData.Repositories
{
    public interface IFilmRepository
    {

    }
    public class FilmRepository: RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
