﻿using DiscordWebhook.Entities;
using DiscordWebhook.Exceptions;
using System.Text;

namespace DiscordWebhook.Core;

public static class WebhookApi
{
    private const string BaseUri = "https://discord.com/api/webhooks";

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
    {
        using var client = new HttpClient();
        var uri = new Uri(ConcentrateUri(id, token));
        client.BaseAddress = uri;

        var request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;

        HttpResponseMessage response = client.Send(request);

        if (!response.IsSuccessStatusCode)
            return null;

        string content = response.Content.ReadAsStringAsync().Result;

        var webhook = Webhook.ParseJSON(content);

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
            throw new WebhookHasNoToken();

        using var client = new HttpClient();
        var uri = new Uri(ConcentrateUri(webhook.Id, webhook.Token));
        client.BaseAddress = uri;

        var request = new HttpRequestMessage();
        request.Method = HttpMethod.Post;
        request.Content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/json");

        HttpResponseMessage response = client.Send(request);

        if (response.IsSuccessStatusCode)
            throw new WebhookRequestFailed(response);
    }

    /// <summary>
    /// Appends the component to the end of the BaseUri, split by a "/"
    /// </summary>
    /// <param name="components">The components of the uri</param>
    /// <returns>The concentrated Uri</returns>
    private static string ConcentrateUri(params object[] components)
    {
        var builder = new StringBuilder(BaseUri);
        for (int i = 0; i < components.Length; i++)
        {
            builder.Append('/');
            builder.Append(components[i]);
        }

        return builder.ToString();
    }
}
