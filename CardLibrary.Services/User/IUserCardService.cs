using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.User
{
   public interface IUserCardService
    {
        List<Data.Models.UserCard> GetAllUserCards();
        Data.Models.UserCard GetUserCardById(int id);
        ServiceResponse<Data.Models.UserCard> CreateUserCard(Data.Models.UserCard usrcard);
        ServiceResponse<bool> DeleteUserCard(int id);
    }
}
