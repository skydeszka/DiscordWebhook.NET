using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhook.Entities;

public struct ExecuteWebhookQuery
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

    public override string ToString()
    {
        var builder = new StringBuilder('?');
        if (wait is not null)
        {
            builder.Append("wait=");
            builder.Append(wait);
            builder.Append('&')
        }

        if(threadId is not null)
        {
            builder.Append("thread_id=");
            builder.Append(threadId);
        }

        return builder.ToString();
    }
}
