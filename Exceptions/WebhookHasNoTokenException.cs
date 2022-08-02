using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;

/// <summary>
/// The exception is thrown when a Webhook object doesn't have a token when required.
/// </summary>
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