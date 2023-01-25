using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.Concrete.EntityFramework.EfRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class UnitofWork : IUnitofWork
    {
        private readonly LeaderboardDb _context;
        private EfUserRepository _UserRepository;
        private EfLeaderboardRepository _LeaderboardRepository;

        public UnitofWork(LeaderboardDb context)
        {
            _context = context;
        }
        public IUserDal User => _UserRepository ?? new EfUserRepository(_context);
        public ILeaderboardDal Leaderboard => _LeaderboardRepository ?? new EfLeaderboardRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
