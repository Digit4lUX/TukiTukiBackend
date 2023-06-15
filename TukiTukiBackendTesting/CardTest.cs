using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Controllers;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackendTesting;

public class CardTest
{
    private readonly CardController _cardController;
    private readonly CardService _cardService;
    
    public CardTest()
    {
        _cardService = new CardService();
        _cardController = new CardController(_cardService);
    }
    
    [Fact]
    public void GetCardsTest()
    {
        var result = _cardController.getAll();
        Assert.IsType<OkObjectResult>(result.Result);
    }

    [Fact]
    public void RegisterCardTest()
    {
        Card card = new Card();
        card.cardNumber = "1234567891234567";
        card.cardHolder = "Javier Gonzales";
        card.caducity = "12/25";
        card.cvv = "123";
        card.dni = "67895432";
        var result = _cardController.create(card);
        Assert.IsType<CreatedResult>(result.Result);
    }
}