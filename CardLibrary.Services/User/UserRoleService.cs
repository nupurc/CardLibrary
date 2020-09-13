using CardLibrary.Data;
using CardLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLibrary.Services.User
{
    public class UserRoleService : IUserRoleService
    {
        private readonly CardLibDbContext _db;
        public UserRoleService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<UserRole> CreateUserRole(UserRole userRole)
        {
            try
            {
                _db.UserRoleLists.Add(userRole);
                _db.SaveChanges();

                return new ServiceResponse<UserRole>
                {
                    Data = userRole,
                    Time = DateTime.UtcNow,
                    Message = "Saved new UserGroup",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<UserRole>
                {
                    Data = userRole,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<bool> DeleteUserRole(int id)
        {
            var userRole = _db.UserRoleLists.Find(id);
            var now = DateTime.UtcNow;

            if (userRole == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "userRole to delete not found!",
                    Data = false
                };
            }

            try
            {
                userRole.isActive = false;
                _db.UserRoleLists.Update(userRole);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "userRole Deleted!",
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

        public List<UserRole> GetAllUserRoles()
        {
            return _db.UserRoleLists.ToList();
        }

        public UserRole GetUserRoleById(int id)
        {
            return _db.UserRoleLists.Find(id);
        }
    }
}
