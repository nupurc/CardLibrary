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
        /// Serializes a UserCard data model into a UserCard view model
        /// </summary>
        /// <param name="UserCard"></param>
        /// <returns></returns>
        public static UserModel SerializeUserCard(User user)
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
                UserRoleModel = user.UserRole,
                UserGroupModel = UserGroupMapper.SerializeUserGroup(user.UserGroup)
            };
        }

        /// <summary>
        /// Serializes a UserCardModel view model into a UserCard data model
        /// </summary>
        /// <param name="UserCardModel"></param>
        /// <returns></returns>
        public static User SerializeUserCard(UserModel userModel)
        {
            return new UserCard
            {
                CardId = userModel.CardId,
                UserCardId = userCardModel.UserCardId,
                UserId = userCardModel.UserId,
                CreatedOn = userCardModel.CreatedOn,
                UpdatedOn = userCardModel.UpdatedOn,
                isActive = userCardModel.isActive,
            };
        }
    }
}
