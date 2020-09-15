using CardLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardLibrary.Services.User
{
    public class UserService : IUserService
    {
        private readonly CardLibDbContext _db;
        public UserService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }

        public ServiceResponse<Data.Models.User> CreateUser(Data.Models.User user)
        {
            try
            {
                _db.UserLists.Add(user);
                _db.SaveChanges();
                return new ServiceResponse<Data.Models.User>
                {
                    IsSuccess = true,
                    Message = "New user added",
                    Time = DateTime.UtcNow,
                    Data = user
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.User>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = user
                };
            }
        }

        public ServiceResponse<bool> DeleteUser(int userid)
        {
            var userlist = _db.UserLists.Find(userid);
            var now = DateTime.UtcNow;

            if (userlist == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "User to delete not found!",
                    Data = false
                };
            }

            try
            {
                _db.UserLists.Remove(userlist);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "User deleted!",
                    Data = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Data = false
                };
            }
        }

        public List<Data.Models.User> GetAllUsers()
        {
            return _db.UserLists                 
                 .OrderBy(usr => usr.LastName)
                 .ToList();
        }

        public Data.Models.User GetUserById(int userid)
        {
            return _db.UserLists.Find(userid);
        }
    }
}
