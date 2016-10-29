using FilmSessionData.Infrastructures;
using FilmSessionModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace FilmSessionData.Repositories
{
    public interface IStatusRepository:IRepository<Status>
    {
        IEnumerable<Status> GetByName();
    }

    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Status> GetByName()
        {
            return this.DbContext.Statuss.ToList();
        }
    }
}