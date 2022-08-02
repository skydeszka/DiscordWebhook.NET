using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

/// <summary>
/// A class representing a Discord Embed.
/// </summary>
public class Embed
{
    /// <summary>
    /// The class containing the limits of several embed components.
    /// </summary>
    public static class EmbedLimits
    {
        /// <summary>
        /// The maximum characters the Title can contain.
        /// </summary>
        public const int TITLE = 256;
        /// <summary>
        /// The maximum characters the Description can contain.
        /// </summary>
        public const int DESCRIPTION = 4096;

        /// <summary>
        /// The maximum Fields the Embed can contain.
        /// </summary>
        public const int FIELDS = 25;
        /// <summary>
        /// The maximum characters a field's title can contain.
        /// </summary>
        public const int FIELDNAME = 256;
        /// <summary>
        /// The maximum characters a field's value can contain.
        /// </summary>
        public const int FIELDVALUE = 1024;

        /// <summary>
        /// The maximum characters the footer can contain.
        /// </summary>
        public const int FOOTERTEXT = 2048;

        /// <summary>
        /// The maximum characters the Author's name can contain.
        /// </summary>
        public const int AUTHORNAME = 256;

        /// <summary>
        /// The maximum characters the Embed can totally contain.
        /// </summary>
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

    /// <summary>
    /// Adds a Field to the Embed.
    /// </summary>
    /// <remarks>An Embed can only hold up to 25 fields.</remarks>
    /// <param name="field">The Embed Field that will be added</param>
    /// <returns>true if the Embed Field is added, otherwise false</returns>
    public bool AddField(EmbedField field)
    {
        if (Fields is null)
            Fields = new List<EmbedField>();

        if (Fields.Count + 1 > EmbedLimits.FIELDS)
            return false;

        Fields.Add(field);

        return true;
    }

    /// <summary>
    /// Removes the Embed Field at the given index.
    /// </summary>
    /// <param name="index">The index of the Embed Field</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="NotSupportedException"></exception>
    public void RemoveFieldAt(int index)
    {
        if (Fields is null)
            return;

        Fields.RemoveAt(index);
    }

    /// <summary>
    /// Removes the Embed field if the Embed contains it.
    /// </summary>
    /// <param name="field">The Embed Field that should be deleted</param>
    /// <returns>
    /// true if item was successfully removed from the Embed; otherwise, false.
    /// </returns>
    /// <exception cref="NotSupportedException"></exception>
    public bool RemoveField(EmbedField field)
    {
        if (Fields is null)
            return false;

        return Fields.Remove(field);
    }

    /// <summary>
    /// Returns the Embed Field with the given index.
    /// </summary>
    /// <param name="index">The Embed Field to return</param>
    /// <returns>The Embed Field with the given index</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public EmbedField? FieldAt(int index) => 
        Fields?[index];

    /// <summary>
    /// Converts the Embed into a JSON object.
    /// </summary>
    /// <returns>The string representative of the JSON object</returns>
    public string ToJSON() => JsonConvert.SerializeObject(this);
}
