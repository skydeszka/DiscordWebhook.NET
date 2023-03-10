using System.Text;

namespace DiscordWebhook.Entities;

/// <summary>
/// The Query options for the Webhook POST request
/// </summary>
internal struct ExecuteWebhookQuery
{
    public bool? wait = null;
    public ulong? threadId = null;

    public ExecuteWebhookQuery(ulong thread_id) =>
        threadId = thread_id;

    public ExecuteWebhookQuery(bool wait) =>
        this.wait = wait;

    public ExecuteWebhookQuery(ulong thread_id, bool wait)
    {
        threadId = thread_id;
        this.wait = wait;
    }

    /// <summary>
    /// Creates the query string
    /// </summary>
    /// <returns>The query string</returns>
    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append('?');
        if (wait is not null)
        {
            builder.Append("wait=");
            builder.Append(wait);
            builder.Append('&');
        }

        if(threadId is not null)
        {
            builder.Append("thread_id=");
            builder.Append(threadId);
        }

        return builder.ToString();
    }
}
