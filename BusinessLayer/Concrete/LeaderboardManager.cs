using BusinessLayer.Abstract;
using BusinessLayer.Dto.LeaderboardDto;
using CoreLayer.Results.Abstract;
using DataAccessLayer.Abstarct;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LeaderboardManager : ILeaderboardService
    {
        protected readonly IUnitofWork _unitofWork;

        // Constructor
        public LeaderboardManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public Task<IDataResult<LeaderboardDto>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LeaderboardDto>> GetByMonth(int Month)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LeaderboardDto>> GetByUserId(ObjectId UserId)
        {
            throw new NotImplementedException();
        }
    }
}
