using DiscordWebhook.Entities.Embeds;
using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

internal struct ExecuteWebhookParams
{
    public string? content;
    public string? username;
    public string? avatar_url;
    public bool? tts;

    public IList<Embed>? embeds;

    //public bool? allowed_mentions;

    public string ToJSON() => JsonConvert.SerializeObject(this);
}
