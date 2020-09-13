using CardLibrary.Data;
using CardLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardLibrary.Services.Group
{
    public class UserGroupService : IUserGroupService
    {
        private readonly CardLibDbContext _db;
        public UserGroupService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<UserGroup> CreateUserGroup(UserGroup userGroup)
        {
            try
            {
                _db.UserGroups.Add(userGroup);
                _db.SaveChanges();

                return new ServiceResponse<UserGroup>
                {
                    Data = userGroup,
                    Time = DateTime.UtcNow,
                    Message = "Saved new UserGroup",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<UserGroup>
                {
                    Data = userGroup,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<bool> DeleteUserGroup(int id)
        {
            var userGroup = _db.UserGroups.Find(id);
            var now = DateTime.UtcNow;

            if (userGroup == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "userGroups to delete not found!",
                    Data = false
                };
            }

            try
            {
                userGroup.IsActive = false;
                _db.UserGroups.Update(userGroup);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "UserGroups Deleted!",
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

        public List<UserGroup> GetAllUserGroups()
        {
            return _db.UserGroups.ToList();
        }

        public UserGroup GetUserGroupById(int id)
        {
            return _db.UserGroups.Find(id);
        }
    }
}
