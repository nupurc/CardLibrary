using CardLibrary.Data.Models;
using CardLibrary.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.Serialization
{
    public static class CardMapper
    {
        /// <summary>
        /// Serializes a Card data model into a Card view model
        /// </summary>
        /// <param name="Card"></param>
        /// <returns></returns>
        public static CardModel SerializeCard(Card card)
        {
            return new CardModel
            {
                CardId = card.CardId,
                Title = card.Title,
                ShortUrl = card.ShortUrl,
                Description = card.Description,
                CardImage = card.CardImage,
                CreatedOn = card.CreatedOn,
                UpdatedOn = card.UpdatedOn,
                isActive = card.isActive,
            };
        }

        /// <summary>
        /// Serializes a CardModel view model into a Card data model
        /// </summary>
        /// <param name="Card"></param>
        /// <returns></returns>
        public static Card SerializeCard(CardModel card)
        {
            return new Card
            {
                CardId = card.CardId,
                Title = card.Title,
                ShortUrl = card.ShortUrl,
                Description = card.Description,
                CardImage = card.CardImage,
                CreatedOn = card.CreatedOn,
                UpdatedOn = card.UpdatedOn,
                isActive = card.isActive,
            };
        }
    }
}
