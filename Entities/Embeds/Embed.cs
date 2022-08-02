using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public class Embed
{
    public static class EmbedLimits
    {
        public const int Title = 256;
        public const int Description = 4096;

        public const int Fields = 25;
        public const int FieldName = 256;
        public const int FieldValue = 1024;

        public const int FooterText = 2048;

        public const int AuthorName = 256;

        public const int TotalMax = 6000;
    }

    #region Properties
    [JsonProperty("title")]
    public string? Title { get; private set; }

    [JsonProperty("type")]
    public EmbedType? Type { get; private set; }

    [JsonProperty("description")]
    public string? Description { get; private set; }

    [JsonProperty("url")]
    public string? Url { get; private set; }

    [JsonProperty("timestamp")]
    public ulong? Timestamp { get; private set; }

    [JsonProperty("color")]
    public int? Color { get; private set; }

    [JsonProperty("footer")]
    public EmbedFooter? Footer { get; private set; }

    [JsonProperty("image")]
    public EmbedImage? Image { get; private set; }

    [JsonProperty("thumbnail")]
    public EmbedThumbnail? Thumbnail { get; private set; }

    [JsonProperty("video")]
    public EmbedVideo? Video { get; private set; }

    [JsonProperty("provider")]
    public EmbedProvider? Provider { get; private set; }

    [JsonProperty("author")]
    public EmbedAuthor? Author { get; private set; }

    [JsonProperty("fields")]
    public EmbedField[]? Fields { get; private set; }
    #endregion
}
