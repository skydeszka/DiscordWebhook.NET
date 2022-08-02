using Ardalis.SmartEnum;

namespace DiscordWebhook.Entities.Embeds;

/// <summary>
/// A class representing the Discord Embed Type
/// </summary>
public sealed class EmbedType : SmartEnum<EmbedType>
{
    public static readonly EmbedType Rich = new("rich", 1);
    public static readonly EmbedType Image = new("image", 2);
    public static readonly EmbedType Video = new("video", 3);
    public static readonly EmbedType Gifv = new("gifv", 4);
    public static readonly EmbedType Article = new("article", 5);
    public static readonly EmbedType Link = new("link", 6);

    public EmbedType(string name, int value) : base(name, value)
    {
    }
}
