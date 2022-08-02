using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

/// <summary>
/// A class representing the Discord Embed Thumbnail
/// </summary>
public struct EmbedThumbnail
{
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [JsonProperty("proxy_url")]
    public string? ProxyUrl { get; set; } = null;

    [JsonProperty("height")]
    public int? Height { get; set; } = null;

    [JsonProperty("width")]
    public int? Width { get; set; } = null;

    public EmbedThumbnail() { }
}
