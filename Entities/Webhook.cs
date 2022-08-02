using DiscordWebhook.Core;
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

    public static Webhook? Fetch(ulong id, string token)
    {
        try { return WebhookApi.Get(id, token); }
        catch (Exception) { return null; }
    }


    public static Webhook? ParseJSON(string jsonObject) =>
        JsonConvert.DeserializeObject<Webhook>(jsonObject);

    public bool SendMessage(WebhookMessageOptions options)
    {
        var parameters = new ExecuteWebhookParams
        {
            content = options.Content,
            username = options.Username,
            avatar_url = options.AvatarUrl,
            tts = options.Tts,
            embeds = options.Embeds
        };

        var query = new ExecuteWebhookQuery
        {
            wait = options.Wait,
            threadId = options.ThreadId
        };

        try { WebhookApi.Post(this, parameters, query); }
        catch (Exception) { return false; }

        return true;
    }

    /// <summary>
    /// Sends a message with the webhook
    /// </summary>
    /// <param name="message">The message to be sent</param>
    /// <param name="useTts">If the message should use TTS</param>
    /// <returns>
    ///     true if the message was sent,
    ///     false if the message was not sent
    /// </returns>
    public bool SendMessageQuick(string message, bool useTts = false)
    {
        var parameters = new ExecuteWebhookParams
        {
            content = message,
            tts = useTts
        };

        try { WebhookApi.Post(this, parameters); }
        catch (Exception) { return false; }

        return true;
    }

    /// <summary>
    /// Sends a message with the webhook and overrides its username
    /// </summary>
    /// <param name="message">The message to be sent</param>
    /// <param name="customUsername">The new username</param>
    /// <param name="useTts">If the message should use TTS</param>
    /// <returns>
    ///     true if the message was sent,
    ///     false if the message was not sent
    /// </returns>
    public bool SendMessageQuick(string message, string customUsername, bool useTts = false)
    {
        var parameters = new ExecuteWebhookParams
        {
            content = message,
            username = customUsername,
            tts = useTts
        };

        try { WebhookApi.Post(this, parameters); }
        catch (Exception) { return false; }

        return true;
    }

    /// <summary>
    /// Sends a message with the webhook to a thread
    /// </summary>
    /// <param name="message">The message to be sent</param>
    /// <param name="thread_id">The ID of the thread</param>
    /// <param name="useTts">If the message should use TTS</param>
    /// <returns>
    ///     true if the message was sent,
    ///     false if the message was not sent
    /// </returns>
    public bool SendMessageInThread(string message, ulong thread_id, bool useTts = false)
    {
        var parameters = new ExecuteWebhookParams
        {
            content = message,
            tts = useTts
        };

        var query = new ExecuteWebhookQuery(thread_id);

        try { WebhookApi.Post(this, parameters, query); }
        catch (Exception) { return false; }

        return true;
    }

    /// <summary>
    /// Sends a message with the webhook to a thread and overrides its username
    /// </summary>
    /// <param name="message">The message to be sent</param>
    /// <param name="customUsername">The new username</param>
    /// <param name="thread_id">The ID of the thread</param>
    /// <param name="useTts">If the message should use TTS</param>
    /// <returns>
    ///     true if the message was sent,
    ///     false if the message was not sent
    /// </returns>
    public bool SendMessageInThread(string message, string customUsername, ulong thread_id, bool useTts = false)
    {
        var parameters = new ExecuteWebhookParams
        {
            content = message,
            username = customUsername,
            tts = useTts
        };

        var query = new ExecuteWebhookQuery(thread_id);

        try { WebhookApi.Post(this, parameters, query); }
        catch (Exception) { return false; }

        return true;
    }

    public string ToJSON() => JsonConvert.SerializeObject(this);
}
