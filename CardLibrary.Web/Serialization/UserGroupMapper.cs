using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.Serialization
{
    public static class UserGroupMapper
    {
        /// <summary>
        /// Serializes a UserCard data model into a UserGroupModel view model
        /// </summary>
        /// <param name="UserGroup"></param>
        /// <returns></returns>
        public static UserGroupModel SerializeUserGroup(UserGroup userGroup)
        {
            return new UserGroupModel
            {
                UserGroupId = userGroup.UserGroupId,
                GroupName = userGroup.GroupName,
                CreatedOn = userGroup.CreatedOn,
                UpdatedOn = userGroup.UpdatedOn,
                IsActive = userGroup.IsActive,
            };
        }

        /// <summary>
        /// Serializes a UserGroupModel view model into a UserCard data model
        /// </summary>
        /// <param name="UserGroupModel"></param>
        /// <returns></returns>
        public static UserGroup SerializeUserGroup(UserGroupModel userGroupModel)
        {
            return new UserGroup
            {
                UserGroupId = userGroupModel.UserGroupId,
                GroupName = userGroupModel.GroupName,
                CreatedOn = userGroupModel.CreatedOn,
                UpdatedOn = userGroupModel.UpdatedOn,
                IsActive = userGroupModel.IsActive,
            };
        }
    }
}
