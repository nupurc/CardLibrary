using CardLibrary.Data;
using CardLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLibrary.Services.Card
{
    public class CardService : ICardService
    {
        private readonly CardLibDbContext _db;
        public CardService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<bool> ArchiveCard(int id)
        {
            var card = _db.Cards.Find(id);
            var now = DateTime.UtcNow;

            if (card == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "Card to delete not found!",
                    Data = false
                };
            }

            try
            {
                 card.isActive = false;
                _db.Cards.Update(card);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "Card Archived!",
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

        public ServiceResponse<Data.Models.Card> CreateCard(Data.Models.Card card)
        {
            try
            {
                _db.Cards.Add(card);
                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Card>
                {
                    Data = card,
                    Time = DateTime.UtcNow,
                    Message = "Saved new card",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Card>
                {
                    Data = card,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public List<Data.Models.Card> GetAllCards()
        {
            return _db.Cards.ToList();
        }

        public Data.Models.Card GetCardById(int id)
        {
            return _db.Cards.Find(id);
        }

        public ServiceResponse<Data.Models.Card> UpdateCard(Data.Models.Card card)
        {
            var carddata = _db.Cards.Find(card.CardId);
            var now = DateTime.UtcNow;

            if (carddata == null)
            {
                return new ServiceResponse<Data.Models.Card>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "Card to Update not found!",
                    Data = card
                };
            }

            try
            {
                carddata.isActive = card.isActive;
                carddata.CardImage = card.CardImage;
                carddata.Description = card.Description;
                carddata.ShortUrl = card.ShortUrl;
                carddata.Title = card.Title;
                carddata.UpdatedOn = card.UpdatedOn;
                _db.Cards.Update(card);
                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Card>
                {
                    Data = card,
                    Time = DateTime.UtcNow,
                    Message = "Saved Updated card",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Card>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Data = card
                };
            }
        }
    }
}
