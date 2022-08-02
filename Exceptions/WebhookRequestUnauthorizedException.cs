using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;

/// <summary>
/// The exception is thrown when a Webhook request responds with a Unauthorized Http code.
/// </summary>
[Serializable]
internal class WebhookRequestUnauthorizedException : Exception
{
    public WebhookRequestUnauthorizedException()
    {
    }

    public WebhookRequestUnauthorizedException(string? message) : base(message)
    {
    }

    public WebhookRequestUnauthorizedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected WebhookRequestUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}