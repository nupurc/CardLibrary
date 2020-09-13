using CardLibrary.Data;
using CardLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLibrary.Services.User
{   
    public class UserCardService : IUserCardService
    {
        private readonly CardLibDbContext _db;
        public UserCardService(CardLibDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<UserCard> CreateUserCard(UserCard usrcard)
        {
            try
            {
                _db.CustomerCards.Add(usrcard);
                _db.SaveChanges();

                return new ServiceResponse<UserCard>
                {
                    Data = usrcard,
                    Time = DateTime.UtcNow,
                    Message = "Saved new UserGroup",
                    IsSuccess = true
                };
            }

            catch (Exception e)
            {
                return new ServiceResponse<UserCard>
                {
                    Data = usrcard,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<bool> DeleteUserCard(int id)
        {
            var usercard = _db.CustomerCards.Find(id);
            var now = DateTime.UtcNow;

            if (usercard == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "userCard to delete not found!",
                    Data = false
                };
            }

            try
            {
                usercard.isActive = false;
                _db.CustomerCards.Update(usercard);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "userCard Deleted!",
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

        public List<UserCard> GetAllUserCards()
        {
           return _db.CustomerCards.ToList();
        }

        public UserCard GetUserCardById(int id)
        {
            return _db.CustomerCards.Find(id);
        }
    }
}
