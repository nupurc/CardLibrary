using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.User
{
   public interface IUserRoleService
    {
        List<Data.Models.UserRole> GetAllUserRoles();
        Data.Models.UserRole GetUserRoleById(int id);
        ServiceResponse<Data.Models.UserRole> CreateUserRole(Data.Models.UserRole userRole);
        ServiceResponse<bool> DeleteUserRole(int id);
    }
}
