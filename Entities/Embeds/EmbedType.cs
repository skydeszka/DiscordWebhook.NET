namespace DiscordWebhook.Entities.Embeds;

public readonly struct EmbedType
{
    public static EmbedType Rich => new("rich");
    public static EmbedType Image => new ("image");
    public static EmbedType Video => new ("video");
    public static EmbedType Gifv => new ("gifv");
    public static EmbedType Article => new ("article");
    public static EmbedType Link => new ("link");

    public readonly string current;

    private EmbedType(string type) => current = type;

    public static bool operator ==(EmbedType a, EmbedType b)
    {
        return a.current == b.current;
    }

    public static bool operator !=(EmbedType a, EmbedType b)
    {
        return a.current != b.current;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not EmbedType type)
            return false;

        return current == type.current;
    }

    public override int GetHashCode() => base.GetHashCode();
}
