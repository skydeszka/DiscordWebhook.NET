using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public class SelectOption
{
    [JsonProperty("label")]
    public string Label { get; set; } = string.Empty;

    [JsonProperty("value")]
    public string Value { get; set; } = string.Empty;

    [JsonProperty("description")]
    public string? Description { get; set; }

    // TODO: emoji

    [JsonProperty("default")]
    public bool Default { get; set; }
}
