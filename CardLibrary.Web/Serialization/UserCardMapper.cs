using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;

namespace CardLibrary.Web.Serialization
{
    public static class UserCardMapper
    {
        /// <summary>
        /// Serializes a UserCard data model into a UserCard view model
        /// </summary>
        /// <param name="UserCard"></param>
        /// <returns></returns>
        public static UserCard SerializeUserCard(UserCard userCard)
        {
            return new UserCard
            {
                CardId = userCard.CardId,
                UserCardId = userCard.UserCardId,
                UserId = userCard.UserId,
                CreatedOn = userCard.CreatedOn,
                UpdatedOn = userCard.UpdatedOn,
                isActive = userCard.isActive,
            };
        }

        /// <summary>
        /// Serializes a UserCardModel view model into a UserCard data model
        /// </summary>
        /// <param name="UserCardModel"></param>
        /// <returns></returns>
        public static UserCard SerializeUserCard(UserCardModel userCardModel)
        {
            return new UserCard
            {
                CardId = userCardModel.CardId,
                UserCardId = userCardModel.UserCardId,
                UserId = userCardModel.UserId,
                CreatedOn = userCardModel.CreatedOn,
                UpdatedOn = userCardModel.UpdatedOn,
                isActive = userCardModel.isActive,
            };
        }
    }
}
