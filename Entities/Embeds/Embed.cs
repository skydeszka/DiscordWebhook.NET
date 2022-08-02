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
    public string? Title { get; set; }

    [JsonProperty("type")]
    public EmbedType? Type { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("url")]
    public string? Url { get; set; }

    [JsonProperty("timestamp")]
    public ulong? Timestamp { get; set; }

    [JsonProperty("color")]
    public int? Color { get; set; }

    [JsonProperty("footer")]
    public EmbedFooter? Footer { get; set; }

    [JsonProperty("image")]
    public EmbedImage? Image { get; set; }

    [JsonProperty("thumbnail")]
    public EmbedThumbnail? Thumbnail { get; set; }

    [JsonProperty("video")]
    public EmbedVideo? Video { get; set; }

    [JsonProperty("provider")]
    public EmbedProvider? Provider { get; set; }

    [JsonProperty("author")]
    public EmbedAuthor? Author { get; set; }

    [JsonProperty("fields")]
    public EmbedField[]? Fields { get; set; }
    #endregion
}
