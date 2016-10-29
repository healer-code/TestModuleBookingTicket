using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FilmSessionData.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TestCodeFirstEntityDbContext dbContext;
        private DbContextTransaction _transaction;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TestCodeFirstEntityDbContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = dbFactory.Init());
            }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public virtual void BeginTransaction()
        {
            _transaction = dbContext.Database.BeginTransaction();
        }

        public virtual void CommitTransaction()
        {
            _transaction.Commit();
            _transaction.Dispose();
        }

        public virtual void RollbacnTran()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}
