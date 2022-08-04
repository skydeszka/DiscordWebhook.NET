namespace DiscordWebhook.Entities.Components;

public class SelectMenu : ICustomComponent
{
    public ComponentType Type => ComponentType.SelectMenu;

    public string? CustomId { get; set; }

    public IList<SelectOption>? Options { get; set; }

    public string? Placeholder { get; set; }

    public int? MinValues { get; set; }

    public int? MaxValues { get; set; }

    public bool Disabled { get; set; }
}
