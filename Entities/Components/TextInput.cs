using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public class TextInput : ICustomComponent
{
    public ComponentType Type => ComponentType.TextInput;

    public string? CustomId { get; set; }

    [JsonProperty("style")]
    public TextInputStyle Style { get; set; } = TextInputStyle.Short;

    [JsonProperty("label")]
    public string Label { get; set; } = string.Empty;

    [JsonProperty("min_length")]
    public int? MinLength { get; set; }

    [JsonProperty("max_length")]
    public int? MaxLength { get; set; }

    [JsonProperty("required")]
    public bool Required { get; set; }

    [JsonProperty("value")]
    public string? Value { get; set; }

    [JsonProperty("placeholder")]
    public string? Placeholder { get; set; }
}
