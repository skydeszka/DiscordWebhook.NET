using Newtonsoft.Json;
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

    [JsonProperty("style")]
    public ButtonStyle Style { get; private set; } = ButtonStyle.Primary;

    [JsonProperty("label")]
    public string? Label { get; set; }

    // TODO: emoji

    [JsonProperty("url")]
    public string? Url { get; set; }

    [JsonProperty("disabled")]
    public bool? Disabled { get; set; }
}
