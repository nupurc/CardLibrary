using CardLibrary.Data.Models;
using CardLibrary.Services.Card;
using CardLibrary.Web.Serialization;
using CardLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace CardLibrary.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ICardService _cardService;
        public CardController(ILogger<UserController> logger, ICardService cardService)
        {
            _cardService = cardService;
            _logger = logger;
        }

        [HttpPost("/api/card")]
        public ActionResult CreateCard([FromBody] CardModel cardModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _logger.LogInformation("Creating a new user");
            cardModel.CreatedOn = DateTime.UtcNow;
            cardModel.UpdatedOn = DateTime.UtcNow;
            var cardData = CardMapper.SerializeCard(cardModel);
            var newcard = _cardService.CreateCard(cardData);
            return Ok(newcard);
        }

        [HttpGet("/api/card")]
        public ActionResult GetCards()
        {
            _logger.LogInformation("Getting Cards");
            var cards = _cardService.GetAllCards();

            var cardModel = cards
                .Select(card => new CardModel
                {
                    CardId = card.CardId,
                    Title = card.Title,
                    ShortUrl = card.ShortUrl,
                    Description = card.Description,
                    CardImage = card.CardImage,
                    CreatedOn = card.CreatedOn,
                    UpdatedOn = card.UpdatedOn,
                    isActive = card.isActive,
                })
                .OrderByDescending(usr => usr.CreatedOn)
                .ToList();

            return Ok(cardModel);
        }

        [HttpDelete("/api/card/{id}")]
        public ActionResult DeleteCard(int id)
        {
            _logger.LogInformation("Deleting a Card");
            var response = _cardService
                .ArchiveCard(id);
            return Ok(response);
        }

        [HttpPut("/api/card")]
        public ActionResult DeleteCard([FromBody] CardModel cardModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var cardData = CardMapper.SerializeCard(cardModel);            
            var updatedCard = _cardService.UpdateCard(cardData);
            return Ok(updatedCard);
        }
    }
}
