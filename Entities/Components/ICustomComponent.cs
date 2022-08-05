using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public interface ICustomComponent : IComponent
{
    [JsonProperty("custom_id")]
    public string? CustomId { get; set; }
}
