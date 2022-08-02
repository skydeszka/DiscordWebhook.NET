using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public class EmbedVideo
{
    [JsonProperty("url")]
    public string? Url { get; private set; }

    [JsonProperty("proxy_url")]
    public string? ProxyUrl { get; private set; }

    [JsonProperty("height")]
    public int? Height { get; private set; } = null;

    [JsonProperty("width")]
    public int? Width { get; private set; } = null;
}
