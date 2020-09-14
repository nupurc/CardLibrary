using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.Serialization
{
    public static class UserRoleMapper
    {
        /// <summary>
        /// Serializes a UserCard data model into a UserGroupModel view model
        /// </summary>
        /// <param name="UserGroup"></param>
        /// <returns></returns>
        public static UserRoleModel SerializeUserRole(UserRole userRole)
        {
            return new UserRoleModel
            {
                UserRoleId = userRole.UserRoleId,
                RoleName = userRole.RoleName,
                CreatedOn = userRole.CreatedOn,
                UpdatedOn = userRole.UpdatedOn,
                isActive = userRole.isActive,
            };
        }

        /// <summary>
        /// Serializes a UserGroupModel view model into a UserCard data model
        /// </summary>
        /// <param name="UserGroupModel"></param>
        /// <returns></returns>
        public static UserRole SerializeUserRole(UserRoleModel userRoleModel)
        {
            return new UserRole
            {
                UserRoleId = userRoleModel.UserRoleId,
                RoleName = userRoleModel.RoleName,
                CreatedOn = userRoleModel.CreatedOn,
                UpdatedOn = userRoleModel.UpdatedOn,
                isActive = userRoleModel.isActive,
            };
        }
    }
}
