namespace DiscordWebhook.Entities;

public struct Attachment
{
    public ulong Id { get; set; }
    public string Filename { get; set; }
    public string? Description { get; set; }
    public string? ContentType { get; set; }
    public int Size { get; set; }
    public string Url { get; set; }
    public string? ProxyUrl { get; set; }
    public int? Height { get; set; }
    public int? Width { get; set; }
    public bool? Ephemeral { get; set; }
}
