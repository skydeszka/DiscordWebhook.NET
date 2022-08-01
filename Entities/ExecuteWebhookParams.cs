using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

public struct ExecuteWebhookParams
{
    public string content;
    public string? username;
    public string? avatar_url;
    public bool? tts;

    // TODO: Implement Embed class
    //public Embed[] embeds;

    public bool? allowed_mentions;

    public override string ToString() => JsonConvert.SerializeObject(this);
}
