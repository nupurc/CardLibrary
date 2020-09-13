using CardLibrary.Data;
using CardLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardLibrary.Services.Card
{
    public class CardGroupService : ICardGroupService
    {
        private readonly CardLibDbContext _db;
        public CardGroupService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<CardGroup> CreateCardGroup(CardGroup cardGroup)
        {
            try
            {
                _db.CardGroups.Add(cardGroup);
                _db.SaveChanges();

                return new ServiceResponse<CardGroup>
                {
                    Data = cardGroup,
                    Time = DateTime.UtcNow,
                    Message = "Saved new UserGroup",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<CardGroup>
                {
                    Data = cardGroup,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<bool> DeleteCardGroup(int id)
        {
            var cardGroup = _db.CardGroups.Find(id);
            var now = DateTime.UtcNow;

            if (cardGroup == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "userRole to delete not found!",
                    Data = false
                };
            }

            try
            {
                cardGroup.isActive = false;
                _db.CardGroups.Update(cardGroup);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "userRole Deleted!",
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

        public List<CardGroup> GetAllCardGroups()
        {
            return _db.CardGroups.ToList();
        }

        public CardGroup GetCardGroupById(int id)
        {
           return _db.CardGroups.Find(id);
        }
    }
}
