using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.Serialization
{
    public static class UserMapper
    {
        /// <summary>
        /// Serializes a User data model into a UserModel view model
        /// </summary>
        /// <param name="UserModel"></param>
        /// <returns></returns>
        public static UserModel SerializeUser(User user)
        {
            return new UserModel
            {
                UserId = user.UserId,
                UsertName = user.UsertName,
                password = user.password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreatedOn = user.CreatedOn,
                UpdatedOn = user.UpdatedOn,
                isActive = user.isActive,
                UserRoleModelId = user.UserRoleId,
                UserGroupModelId = user.UserGroupId
            };
        }

        /// <summary>
        /// Serializes a UserModel view model into a User data model
        /// </summary>
        /// <param name="UserModel"></param>
        /// <returns></returns>
        public static User SerializeUser(UserModel userModel)
        {
            return new User
            {
                UserId = userModel.UserId,
                UsertName = userModel.UsertName,
                password = userModel.password,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                CreatedOn = userModel.CreatedOn,
                UpdatedOn = userModel.UpdatedOn,
                isActive = userModel.isActive,
                UserRoleId = userModel.UserRoleModelId,
                UserGroupId = userModel.UserRoleModelId
            };
        }
    }
}
