using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

internal struct ExecuteWebhookParams
{
    public string? content;
    public string? username;
    public string? avatar_url;
    public bool? tts;

    // TODO: Implement Embed class
    //public Embed[] embeds;

    //public bool? allowed_mentions;

    public string ToJSON() => JsonConvert.SerializeObject(this);
}
