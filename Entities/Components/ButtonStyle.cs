using Ardalis.SmartEnum;

namespace DiscordWebhook.Entities.Components;

public sealed class ButtonStyle : SmartEnum<ButtonStyle>
{
    public static readonly ButtonStyle Primary = new("primary", 1);
    public static readonly ButtonStyle Secondary = new("secondary", 2);
    public static readonly ButtonStyle Success = new("succes", 3);
    public static readonly ButtonStyle Danger = new("danger", 4);
    public static readonly ButtonStyle Link = new("link", 5);

    public ButtonStyle(string name, int value) : base(name, value)
    {
    }
}
