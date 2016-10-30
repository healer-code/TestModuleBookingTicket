using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;

namespace FilmSessionData.Repositories
{
    public interface IRoomFilmRepository:IRepository<RoomFilm>
    {

    }
    public class RoomFilmRepository: RepositoryBase<RoomFilm>, IRoomFilmRepository
    {
        public RoomFilmRepository(DbFactory dbFactory):base(dbFactory)
        {

        }

    }
}
