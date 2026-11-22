namespace MiniMonopoly;

public class Deck
{
    public static Card[] ChanceCards =
    [
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.AdvanceToNearest, 0),
        new (Card.Type.AdvanceToNearest, 0),
        new (Card.Type.AdvanceToNearest, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.GetOutOfJailFree, 0),
        new (Card.Type.GoBack, 3),
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0)
    ];

    public static Card[] CommunityCards =
    [
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.GetOutOfJailFree, 0),
        new (Card.Type.AdvanceToSquare, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
        new (Card.Type.Ignored, 0),
    ];

    private readonly Card[] _cards;
    private Card[] _drawPile;
    private uint _drawPileSize;

    public Deck(Card[] cards)
    {
        _cards = cards;
        _drawPile = [.. _cards.Select(a => new Card(a)).Shuffle()];
    }

    public Card Draw()
    {
        if (_drawPileSize == 0)
        {
            _drawPile = [.. _cards.Select(a => new Card(a)).Shuffle()];
            _drawPileSize = (uint)_cards.Length;
        }
        return new Card(_drawPile[--_drawPileSize]);
    }
}