using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.Group
{
   public interface IUserGroupService
    {
        List<Data.Models.UserGroup> GetAllUserGroups();
        Data.Models.UserGroup GetUserGroupById(int id);
        ServiceResponse<Data.Models.UserGroup> CreateUserGroup(Data.Models.UserGroup userGroup);
        ServiceResponse<bool> DeleteUserGroup(int id);
    }
}
