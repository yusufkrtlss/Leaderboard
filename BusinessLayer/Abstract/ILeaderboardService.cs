using BusinessLayer.Dto.LeaderboardDto;
using CoreLayer.Results.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILeaderboardService
    {
        Task<IDataResult<LeaderboardDto>> GetByMonth(int Month); // Get By Month
        Task<IDataResult<LeaderboardDto>> GetByUserId(ObjectId UserId); // Get By User Id
        Task<IDataResult<LeaderboardDto>> GetAllUsers(); // Get All Users

    }
}
