using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

/// <summary>
/// A class representing the Discord Embed Provider
/// </summary>
public struct EmbedProvider
{
    [JsonProperty("name")]
    public string? Name { get; set; } = null;

    [JsonProperty("url")]
    public string? Url { get; set; } = null;

    public EmbedProvider() { }
}
