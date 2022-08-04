using Ardalis.SmartEnum;

namespace DiscordWebhook.Entities.Components;

public sealed class ComponentType : SmartEnum<ComponentType>
{
    public static readonly ComponentType ActionRow = new(nameof(ActionRow), 1);
    public static readonly ComponentType Button = new(nameof(Button), 2);
    public static readonly ComponentType SelectMenu = new(nameof(SelectMenu), 3);
    public static readonly ComponentType TextInput = new(nameof(TextInput), 4);

    public ComponentType(string name, int value) : base(name, value)
    {
    }
}
