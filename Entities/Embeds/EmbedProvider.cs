using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public class EmbedProvider
{
    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("url")]
    public string? Url { get; private set; }
}
