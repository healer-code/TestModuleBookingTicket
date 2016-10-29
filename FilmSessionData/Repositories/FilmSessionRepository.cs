using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;

namespace FilmSessionData.Repositories
{
    public interface IFilmSessionRepository:IRepository<FilmSession>
    {

    }
    public class FilmSessionRepository:RepositoryBase<FilmSession>,IFilmSessionRepository
    {
        public FilmSessionRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
