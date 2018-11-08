using QLHD.Data.Infrastructure;
using QLHD.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Data.Repositories
{
    public interface IdmhuongdanRepository : IRepository<dmhuongdan>
    {
    }

    public class dmhuongdanRepository : RepositoryBase<dmhuongdan>, IdmhuongdanRepository
    {
        public dmhuongdanRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}
