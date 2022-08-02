using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;
[Serializable]
internal class WebhookUnauthorizedException : Exception
{
    public WebhookUnauthorizedException()
    {
    }

    public WebhookUnauthorizedException(string? message) : base(message)
    {
    }

    public WebhookUnauthorizedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected WebhookUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}