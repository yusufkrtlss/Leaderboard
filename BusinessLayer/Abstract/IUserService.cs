using BusinessLayer.Dto.UserDto;
using CoreLayer.Results.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<UserDto>> GetByUserId(ObjectId UserId); // Get by User Id & User_Id
        Task<IDataResult<UserDto>> GetById(ObjectId Id); // Get by Id & Id
        Task<IDataResult<UserListDto>> GetAllUsers(); // Get All Users

    }
}
