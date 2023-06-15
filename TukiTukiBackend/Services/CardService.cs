using TukiTukiBackend.Models;

namespace TukiTukiBackend.Services;

public class CardService: ICRUDService<Card>
{
    private List<Card> cards = new List<Card>()
    {
        new Card() { cardNumber = "1234567890123456", caducity = "12/24", cardHolder = "Juan Perez", cvv = "123", dni = "12345678" },
        new Card() { cardNumber = "1234567890123457", caducity = "12/24", cardHolder = "Javier Ramirez", cvv = "986", dni = "98634752" },
    };

    public IEnumerable<Card> getAll()
    {
        return cards;
    }

    public Card? getById(int id)
    {
        throw new NotImplementedException();
    }

    public Card create(Card item)
    {
        cards.Add(item);
        return item;
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
    
    public Card findByCardNumber(string cardNumber)
    {
        return cards.Find(card => card.cardNumber == cardNumber);
    }
}