using BusinessLayer.Abstract;
using BusinessLayer.Dto.UserDto;
using CoreLayer.Results.Abstract;
using CoreLayer.Results.Concrete;
using DataAccessLayer.Abstarct;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        protected readonly IUnitofWork _unitofWork;
        
        // Constructor
        public UserManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        // Get All Users
        public async Task<IDataResult<UserListDto>> GetAllUsers()
        {
            var user = await _unitofWork.User.GetAllAsync(c => c.IsApproved == true);
            if(user.Count() > 0)
            {
                return new DataResult<UserListDto>(ResultStatus.Success, new UserListDto
                {
                    Users = (List<EntityLayer.Concrete.User>)user
                });
            }
            else
            {
                // Do nothing
            }
            return new DataResult<UserListDto>(ResultStatus.Error, "Couldn't find any user", new UserListDto
            {
                Users = null
            });
        }

        // Get By Id
        public async Task<IDataResult<UserDto>> GetById(ObjectId Id)
        {
            try
            {
                var user = await _unitofWork.User.GetById(c => c.Id == Id);
                if (user != null)
                {
                    return new DataResult<UserDto>(ResultStatus.Success, new UserDto
                    {
                        User = user
                    });
                }
                else
                {
                    // Do nothing 
                }
                return new DataResult<UserDto>(ResultStatus.Error, "Couldn't find any user", new UserDto
                {
                    User = null
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // Get By User Id
        public async Task<IDataResult<UserDto>> GetByUserId(ObjectId UserId)
        {
            try
            {
                var user = await _unitofWork.User.GetById(c => c.UserId == UserId);
                if (user != null)
                {
                    return new DataResult<UserDto>(ResultStatus.Success, new UserDto
                    {
                        User = user
                    });
                }
                else
                {
                    // Do nothing 
                }
                return new DataResult<UserDto>(ResultStatus.Error, "Couldn't find any user", new UserDto
                {
                    User = null
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
