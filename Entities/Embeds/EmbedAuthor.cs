using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public class EmbedAuthor
{
    [JsonProperty("name")]
    public string Name { get; private set; } = string.Empty;

    [JsonProperty("url")]
    public string? Url { get; private set; }

    [JsonProperty("icon_url")]
    public string? IconUrl { get; private set; }

    [JsonProperty("proxy_icon_url")]
    public string? ProxyIconUrl { get; private set; }
}
