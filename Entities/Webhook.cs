using Newtonsoft.Json;

namespace DiscordWebhook.Entities;

public class Webhook
{
    #region Properties
    [JsonProperty("id")]
    public ulong Id { get; private set; }
    [JsonProperty("type")]
    public WebhookType Type { get; private set; }
    [JsonProperty("guild_id")]
    public ulong? GuildId { get; private set; }
    [JsonProperty("channel_id")]
    public ulong? ChannelId { get; private set; }

    // TODO: Implement User class later
    //public User? User { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }
    [JsonProperty("avatar")]
    public string? Avatar { get; private set; }
    [JsonProperty("token")]
    public string? Token { get; private set; }
    [JsonProperty("application_id")]
    public ulong? ApplicationId { get; private set; }

    // TODO: Implement Guild class later
    //public Guild? SourceGuild { get; private set; }
    // TODO: Implement Channel class later
    //public Channel? SourceChannel { get; private set; }

    [JsonProperty("url")]
    public string? Url { get; private set; }

    #endregion

    public Webhook(
        int type, ulong id,
        string name, string? avatar,
        ulong? channel_id, ulong? guild_id,
        ulong? application_id, string? token)
    {
        Type = (WebhookType)type;
        Id = id;
        Name = name;
        Avatar = avatar;
        ChannelId = channel_id;
        GuildId = guild_id;
        ApplicationId = application_id;
        Token = token;
    }

    public static Webhook? ParseJSON(string jsonObject)
    {
        var test = JsonConvert.DeserializeObject<Webhook>(jsonObject);

        return test;
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
