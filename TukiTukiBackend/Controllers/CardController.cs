using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardController: ControllerBase
{
    private readonly CardService _cardService;
    public CardController(CardService cardService)
    {
        _cardService = cardService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Card>> getAll()
    {
        var result = _cardService.getAll();
        return Ok(result);
    }
    
    [HttpPost]
    public ActionResult<Card> create(Card card)
    {
        var existingCard = _cardService.findByCardNumber(card.cardNumber);
        if (existingCard != null)
        {
            return Conflict(new {message = "Card already exists"});
        }
        var result = _cardService.create(card);
        return Created("api/cards", result);
    }
}