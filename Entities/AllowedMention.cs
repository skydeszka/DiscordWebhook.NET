using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

public struct AllowedMention
{
    [JsonProperty("parse")]
    public IList<AllowedMentionType>? Parse { get; set; } = null;

    [JsonProperty("roles")]
    public IList<ulong>? Roles { get; set; } = null;

    [JsonProperty("users")]
    public IList<ulong>? Users { get; set; } = null;

    [JsonProperty("replied_user")]
    public bool RepliedUser { get; set; } = false;

    public AllowedMention() { }
}
