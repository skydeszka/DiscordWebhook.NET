using System.Runtime.Serialization;

namespace DiscordWebhook.Exceptions;

/// <summary>
/// The exception is thrown when a Webhook request failed with an unhandled Http error code.
/// </summary>
[Serializable]
internal class WebhookRequestFailedException : Exception
{
    public WebhookRequestFailedException(HttpResponseMessage response)
        : base(response.Content.ReadAsStringAsync().Result)
    {
    }

    public WebhookRequestFailedException(HttpResponseMessage response, Exception? innerException)
        : base(response.Content.ReadAsStringAsync().Result, innerException)
    {
    }

    protected WebhookRequestFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}