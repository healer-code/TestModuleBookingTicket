using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSessionData.Infrastructures
{
    public class DbFactory : Disposeable, IDbFactory
    {
        TestCodeFirstEntityDbContext dbContext;
        public TestCodeFirstEntityDbContext Init()
        {
            return dbContext ?? (dbContext = new TestCodeFirstEntityDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
