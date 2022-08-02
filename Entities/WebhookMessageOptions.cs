using DiscordWebhook.Entities.Embeds;

namespace DiscordWebhook.Entities;

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
    // TODO: Implement AllowedMentions class
    //public AllowedMentions? AllowedMentions = null;
    // TODO: Implement rest of params
    // https://discord.com/developers/docs/resources/webhook#execute-webhook

    public WebhookMessageOptions() { }
}