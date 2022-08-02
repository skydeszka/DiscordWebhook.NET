using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Embeds;

public struct EmbedField
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("value")]
    public string Value { get; set; } = string.Empty;

    [JsonProperty("inline")]
    public bool? Inline { get; set; } = null;

    public EmbedField() { }
}
