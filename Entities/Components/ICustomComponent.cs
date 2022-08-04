namespace DiscordWebhook.Entities.Components;

public interface ICustomComponent : IComponent
{
    public string? CustomId { get; set; }
}
