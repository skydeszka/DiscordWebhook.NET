using System.Diagnostics.CodeAnalysis;

namespace DiscordWebhook.Entities.Embeds;

public readonly struct EmbedType
{
    public EmbedType Rich => new EmbedType("rich");
    public EmbedType Image => new EmbedType("image");
    public EmbedType Video => new EmbedType("video");
    public EmbedType Gifv => new EmbedType("gifv");
    public EmbedType Article => new EmbedType("article");
    public EmbedType Link => new EmbedType("link");

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
