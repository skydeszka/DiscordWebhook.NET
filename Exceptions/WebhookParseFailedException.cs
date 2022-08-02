using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;

/// <summary>
/// The exception is thrown when a Webhook cannot be parsed from a JSON object.
/// </summary>
[Serializable]
internal class WebhookParseFailedException : Exception
{
    private readonly string _json;

    public string Json => _json;

    public WebhookParseFailedException(string json)
    {
        _json = json;
    }

    public WebhookParseFailedException(string json, string? message) : base(message)
    {
        _json = json;
    }

    public WebhookParseFailedException(string json, string? message, Exception? innerException) : base(message, innerException)
    {
        _json = json;
    }

    protected WebhookParseFailedException(string json, SerializationInfo info, StreamingContext context) : base(info, context)
    {
        _json = json;
    }
}