namespace DiscordWebhook.Exceptions;

public class WebhookRequestFailed : Exception
{
    public WebhookRequestFailed(HttpResponseMessage response)
        : base(response.Content.ReadAsStringAsync().Result)
    {
    }
}
