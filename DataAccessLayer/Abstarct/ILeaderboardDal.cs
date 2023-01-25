using CoreLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface ILeaderboardDal : IEntityRepository<Leaderboard>
    {
    }
}
