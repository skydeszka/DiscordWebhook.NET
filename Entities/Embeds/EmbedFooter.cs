using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public struct EmbedFooter
{
    [JsonProperty("text")]
    public string Text { get; set; } = string.Empty;

    [JsonProperty("icon_url")]
    public string? IconUrl { get; set; } = null;

    [JsonProperty("proxy_icon_url")]
    public string? ProxyIconUrl { get; set; } = null;

    public EmbedFooter() { }
}
