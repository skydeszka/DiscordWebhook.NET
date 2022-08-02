using DiscordWebhook.Exceptions;
using DiscordWebhook.Entities;
using System.Text;

namespace DiscordWebhook.Core;

internal static class WebhookApi
{
    private const string BASEURI = "https://discord.com/api/webhooks";

    /// <summary>
    /// Sends a Get request to the Discord API to get the webhook object
    /// </summary>
    /// <param name="id">ID of the webhook</param>
    /// <param name="token">Token of the webhook</param>
    /// <returns>
    ///     Webhook if the request was successful,
    ///     null if the request was unsuccessful
    /// </returns>
    public static Webhook? Get(ulong id, string token)
    public static Webhook Get(ulong id, string token)
    {
        using var client = new HttpClient();
        var uri = ConcentrateUri(id, token);
        client.BaseAddress = uri;

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get
        };

        HttpResponseMessage response = client.Send(request);

        if (!response.IsSuccessStatusCode)
        {
            throw response.StatusCode switch
            {
                HttpStatusCode.Unauthorized => new WebhookUnauthorizedException(),
                _ => new WebhookRequestFailedException(response),
            };
        }

        string content = response.Content.ReadAsStringAsync().Result;

        var webhook = Webhook.ParseJSON(content);

        if (webhook is null)
            throw new WebhookParseFailedException(content);

        return webhook;
    }

    /// <summary>
    /// Sends a Post request to the Discord API to execute the parameters with the webhook
    /// </summary>
    /// <param name="webhook">The executed webhook</param>
    /// <param name="parameters">The execution parameters</param>
    /// <exception cref="WebhookHasNoToken"></exception>
    /// <exception cref="WebhookRequestFailed"></exception>
    public static void Post(Webhook webhook, ExecuteWebhookParams parameters)
    {
        if (webhook.Token is null)
            throw new WebhookHasNoTokenException();

        using var client = new HttpClient();
        var uri = ConcentrateUri(webhook.Id, webhook.Token);
        client.BaseAddress = uri;

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            Content = new StringContent(parameters.ToJSON(), Encoding.UTF8, "application/json")
        };

        HttpResponseMessage response = client.Send(request);

        if (!response.IsSuccessStatusCode)
            throw new WebhookRequestFailedException(response);
    }

    /// <summary>
    /// Sends a Post request to the Discord API to execute the parameters with the webhook
    /// </summary>
    /// <param name="webhook">The executed webhook</param>
    /// <param name="parameters">The execution parameters</param>
    /// <param name="query">The query parameters</param>
    /// <exception cref="WebhookHasNoToken"></exception>
    /// <exception cref="WebhookRequestFailed"></exception>
    public static void Post(Webhook webhook, ExecuteWebhookParams parameters, ExecuteWebhookQuery query)
    {
        if (webhook.Token is null)
            throw new WebhookHasNoTokenException();

        using var client = new HttpClient();
        var uri = ConcentrateUriWithQuery(query.ToString(), webhook.Id, webhook.Token);
        client.BaseAddress = uri;

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            Content = new StringContent(parameters.ToJSON(), Encoding.UTF8, "application/json")
        };

        HttpResponseMessage response = client.Send(request);

        if (!response.IsSuccessStatusCode)
            throw new WebhookRequestFailedException(response);
    }

    /// <summary>
    /// Appends the component to the end of the BaseUri, split by a "/"
    /// </summary>
    /// <param name="components">The components of the uri</param>
    /// <returns>The concentrated Uri</returns>
    private static Uri ConcentrateUri(params object[] components)
    {
        var builder = new StringBuilder(BASEURI);
        for (int i = 0; i < components.Length; i++)
        {
            builder.Append('/');
            builder.Append(components[i]);
        }

        return new Uri(builder.ToString());
    }

    /// <summary>
    /// Appends the component to the end of the BaseUri, split by a "/"
    /// then appends the query to the very end
    /// </summary>
    /// <param name="query">The query to append to the end</param>
    /// <param name="components">The components of the uri</param>
    /// <returns>The concentrated Uri and query</returns>
    private static Uri ConcentrateUriWithQuery(string query, params object[] components)
    {
        var builder = new StringBuilder(BASEURI);
        for (int i = 0; i < components.Length; i++)
        {
            builder.Append('/');
            builder.Append(components[i]);
        }

        if (!query.StartsWith("?"))
            builder.Append('?');

        builder.Append(query);

        return new Uri(builder.ToString());
    }
}
