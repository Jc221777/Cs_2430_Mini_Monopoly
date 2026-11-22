namespace MiniMonopoly;

public class Space
{
    enum Type
    {
        Property,
        CommunityChest,
        Utility,
        Railroad,
        Chance,
        Tax,
        Go,
        Jail,
        GoToJail,
        FreeParking
    }

    private Type _type;
    
    Space(Type type)
    {
        _type = type;
    }
    
    private static Space[] Board =
    [
        new (Type.Go),
        new (Type.Property),
        new (Type.CommunityChest),
        new (Type.Property),
        new (Type.Tax),
        new (Type.Railroad),
        new (Type.Property),
        new (Type.Chance),
        new (Type.Property),
        new (Type.Property),
        new (Type.GoToJail),
        new (Type.Property),
        new (Type.Utility),
        new (Type.Property),
        new (Type.Tax),
        new (Type.Railroad),
        new (Type.Property),
        new (Type.Chance),
        new (Type.Property),
        new (Type.Property),
        new (Type.Jail),
        new (Type.Property),
        new (Type.Utility),
        new (Type.Property),
        new (Type.Property),
        new (Type.Railroad),
        new (Type.Property),
        new (Type.CommunityChest),
        new (Type.Property),
        new (Type.Property),
        new (Type.FreeParking),
        new (Type.Property),
        new (Type.Chance),
        new (Type.Property),
        new (Type.Property),
        new (Type.Railroad),
        new (Type.Property),
        new (Type.Property),
        new (Type.Utility),
        new (Type.Property),
    ];
}