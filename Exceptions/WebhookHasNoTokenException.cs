using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;
[Serializable]
internal class WebhookHasNoTokenException : Exception
{
    public WebhookHasNoTokenException()
    {
    }

    public WebhookHasNoTokenException(string? message) : base(message)
    {
    }

    public WebhookHasNoTokenException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected WebhookHasNoTokenException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}