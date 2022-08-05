using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public interface IComponent
{
    [JsonProperty("type")]
    public ComponentType Type { get; }
}
