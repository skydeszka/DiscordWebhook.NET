﻿namespace DiscordWebhook.Entities.Components;

public class SelectOption
{
    public string Label { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;

    public string? Description { get; set; }

    // TODO: emoji

    public bool Default { get; set; }
}
