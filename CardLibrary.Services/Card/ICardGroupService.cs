using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.Card
{
   public interface ICardGroupService
    {
        List<Data.Models.CardGroup> GetAllCardGroups();
        Data.Models.CardGroup GetCardGroupById(int id);
        ServiceResponse<Data.Models.CardGroup> CreateCardGroup(Data.Models.CardGroup cardGroup);
        ServiceResponse<bool> DeleteCardGroup(int id);
    }
}
