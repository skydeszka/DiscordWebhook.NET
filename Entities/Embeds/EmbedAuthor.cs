using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public struct EmbedAuthor
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("url")]
    public string? Url { get; set; } = null;

    [JsonProperty("icon_url")]
    public string? IconUrl { get; set; } = null;

    [JsonProperty("proxy_icon_url")]
    public string? ProxyIconUrl { get; set; } = null;

    public EmbedAuthor() { }
}
