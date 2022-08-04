namespace DiscordWebhook.Entities.Components;

public class TextInput : ICustomComponent
{
    public ComponentType Type => ComponentType.TextInput;

    public string? CustomId { get; set; }

    public TextInputStyle Style { get; set; } = TextInputStyle.Short;

    public string Label { get; set; } = string.Empty;

    public int? MinLength { get; set; }

    public int? MaxLength { get; set; }

    public bool Required { get; set; }

    public string? Value { get; set; }

    public string? Placeholder { get; set; }
}
