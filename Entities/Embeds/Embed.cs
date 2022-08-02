using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public class Embed
{
    public static class EmbedLimits
    {
        public const int TITLE = 256;
        public const int DESCRIPTION = 4096;

        public const int FIELDS = 25;
        public const int FIELDNAME = 256;
        public const int FIELDVALUE = 1024;

        public const int FOOTERTEXT = 2048;

        public const int AUTHORNAME = 256;

        public const int TOTALMAX = 6000;
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
    public IList<EmbedField>? Fields { get; private set; }
    #endregion

    public bool AddField(EmbedField field)
    {
        if (Fields is null)
            Fields = new List<EmbedField>();

        if (Fields.Count + 1 > EmbedLimits.FIELDS)
            return false;

        Fields.Add(field);

        return true;
    }

    public void RemoveFieldAt(int index)
    {
        if (Fields is null)
            return;

        Fields.RemoveAt(index);
    }

    public bool RemoveField(EmbedField field)
    {
        if (Fields is null)
            return false;

        return Fields.Remove(field);
    }

    public EmbedField? FieldAt(int index) => 
        Fields is null ? null : Fields[index];
}
