using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Services.Card
{
   public interface ICardService
    {
        List<Data.Models.Card> GetAllCards();
        Data.Models.Card GetCardById(int id);
        ServiceResponse<Data.Models.Card> CreateCard(Data.Models.Card card);
        ServiceResponse<bool> ArchiveCard(int id);
        ServiceResponse<Data.Models.Card> UpdateCard(Data.Models.Card card);
    }
}
