using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;

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