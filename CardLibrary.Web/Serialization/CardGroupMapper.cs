using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;

namespace CardLibrary.Web.Serialization
{
    public static class CardGroupMapper
    {
        /// <summary>
        /// Serializes a CardGroup data model into a CardGroup view model
        /// </summary>
        /// <param name="CardGroup"></param>
        /// <returns></returns>
        public static CardGroupModel SerializeCardGroup(CardGroup cardGroup)
        {
            return new CardGroupModel
            {
                CardGroupId = cardGroup.CardGroupId,
                CardId = cardGroup.CardId,
                GroupId = cardGroup.GroupId,
                CreatedOn = cardGroup.CreatedOn,
                UpdatedOn = cardGroup.UpdatedOn,
                isActive = cardGroup.isActive,
            };
        }

        /// <summary>
        /// Serializes a CardGroupModel view model into a CardGroup data model
        /// </summary>
        /// <param name="CardGroup"></param>
        /// <returns></returns>
        public static CardGroup SerializeCardGroup(CardGroupModel cardGroup)
        {
            return new CardGroup
            {
                CardGroupId = cardGroup.CardGroupId,
                CardId = cardGroup.CardId,
                GroupId = cardGroup.GroupId,
                CreatedOn = cardGroup.CreatedOn,
                UpdatedOn = cardGroup.UpdatedOn,
                isActive = cardGroup.isActive,
            };
        }
    }
}
