using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;

namespace FilmSessionData.Repositories
{
    public interface ICinemaRepository:IRepository<Cinema>
    {

    }
    public class CinemaRepository: RepositoryBase<Cinema>, ICinemaRepository
    {
        public CinemaRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
