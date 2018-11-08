using QLHD.Data.Models;

namespace QLHD.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private QLHDDbContext dbContext;

        public QLHDDbContext Init()
        {
            return dbContext ?? (dbContext = new QLHDDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}