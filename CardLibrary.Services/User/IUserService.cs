using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.User
{
   public interface IUserService
    {
        List<Data.Models.User> GetAllUsers();
        ServiceResponse<Data.Models.User> CreateUser(Data.Models.User user);
        ServiceResponse<bool> DeleteUser(int userid);
        Data.Models.User GetUserById(int userid);
    }
}
