namespace DiscordWebhook.Entities.Components;

public class ActionRow : IComponent
{
    public ComponentType Type => ComponentType.ActionRow;

    public IList<ICustomComponent>? Components { get; set; }
}
