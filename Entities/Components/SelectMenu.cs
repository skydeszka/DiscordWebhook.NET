using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public class SelectMenu : ICustomComponent
{
    public ComponentType Type => ComponentType.SelectMenu;

    public string? CustomId { get; set; }

    [JsonProperty("options")]
    public IList<SelectOption>? Options { get; set; }

    [JsonProperty("placeholder")]
    public string? Placeholder { get; set; }

    [JsonProperty("min_values")]
    public int? MinValues { get; set; }

    [JsonProperty("max_values")]
    public int? MaxValues { get; set; }

    [JsonProperty("disabled")]
    public bool Disabled { get; set; }
}
