using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhook.Entities.Components;

public class Button : ICustomComponent
{
    public const int LABEL_LIMIT = 80;

    private string? _url;

    public ComponentType Type => ComponentType.Button;

    public string? CustomId { get; set; }

    public ButtonStyle Style { get; private set; } = ButtonStyle.Primary;

    public string? Label { get; set; }

    // TODO: emoji

    public string? Url { get; set; }

    public bool? Disabled { get; set; }
}
