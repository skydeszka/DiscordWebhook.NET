using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

/// <summary>
/// A class representing the Discord Embed Video
/// </summary>
public struct EmbedVideo
{
    [JsonProperty("url")]
    public string? Url { get; set; } = null;

    [JsonProperty("proxy_url")]
    public string? ProxyUrl { get; set; } = null;

    [JsonProperty("height")]
    public int? Height { get; set; } = null;

    [JsonProperty("width")]
    public int? Width { get; set; } = null;

    public EmbedVideo() { }
}
