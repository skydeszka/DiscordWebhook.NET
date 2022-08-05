using Newtonsoft.Json;

namespace DiscordWebhook.Entities.Components;

public class ActionRow : IComponent
{
    public ComponentType Type => ComponentType.ActionRow;

    [JsonProperty("components")]
    public IList<ICustomComponent>? Components { get; set; }
}
