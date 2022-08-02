using DiscordWebhook.Entities.Embeds;
using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

/// <summary>
/// The body parameters for the Webhook POST request
/// </summary>
internal struct ExecuteWebhookParams
{
    public string? content;
    public string? username;
    public string? avatar_url;
    public bool? tts;

    public IList<Embed>? embeds;

    //public bool? allowed_mentions;

    /// <summary>
    /// Converts the parameters into a JSON object
    /// </summary>
    /// <returns>The string representative of the JSON object</returns>
    public string ToJSON() => JsonConvert.SerializeObject(this);
}
