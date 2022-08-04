using Ardalis.SmartEnum;

namespace DiscordWebhook.Entities.Components;

public class TextInputStyle : SmartEnum<TextInputStyle>
{
    public static readonly TextInputStyle Short = new("short", 1);

    public static readonly TextInputStyle Paragraph = new("paragraph", 2);

    public TextInputStyle(string name, int value) : base(name, value)
    {
    }
}
