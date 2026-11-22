namespace MiniMonopoly;

public class Card
{
    public enum Type
    {
        AdvanceToSquare,
        AdvanceToNearest,
        GetOutOfJailFree,
        GoBack,
        Ignored
    }

    private readonly Type _type;
    private readonly uint _payload;

    public Card(Card card)
    {
        _type = card._type;
        _payload = card._payload;
    }
    
    public Card(Type type, uint payload)
    {
        _type = type;
        _payload = payload;
    }

    void handle(Player player)
    {
    }
}