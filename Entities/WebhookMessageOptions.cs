using DiscordWebhook.Entities.Components;
using DiscordWebhook.Entities.Embeds;

namespace DiscordWebhook.Entities;

/// <summary>
/// Contains all message options for a Webhook message.
/// </summary>
public struct WebhookMessageOptions
{
    //Query String Params
    public bool Wait = false;
    public ulong? ThreadId = null;

    //JSON/Form Params
    public string? Content = null;
    public string? Username = null;
    public string? AvatarUrl = null;

    public bool Tts = false;

    public IList<Embed>? Embeds = null;
    public AllowedMention? AllowedMentions = null;

    //Requires application-owned webhook
    public IList<Component>? Components = null;

    //  TODO: FILES
    //  files[n]
    //  payload_json
    //  attachments

    public bool SupressEmbeds = false;

    public string? ThreadName = null;

    public WebhookMessageOptions() { }
}