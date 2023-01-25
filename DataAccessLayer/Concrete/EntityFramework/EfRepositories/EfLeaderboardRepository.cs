using CoreLayer.Data.Concrete;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.EfRepositories
{
    public class EfLeaderboardRepository : EfEntityRepositoryBase<Leaderboard>, ILeaderboardDal
    {
        public EfLeaderboardRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
