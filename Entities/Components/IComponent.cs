namespace DiscordWebhook.Entities.Components;

public interface IComponent
{
    public ComponentType Type { get; }

    public string? CustomId { get; set; }
}
