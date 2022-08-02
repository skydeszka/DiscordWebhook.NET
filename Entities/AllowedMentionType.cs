using Ardalis.SmartEnum;

namespace DiscordWebhook.Entities;

public sealed class AllowedMentionType : SmartEnum<AllowedMentionType>
{
    public static readonly AllowedMentionType RoleMentions = new("roles", 1);
    public static readonly AllowedMentionType UserMentions = new("users", 2);
    public static readonly AllowedMentionType EveryoneMentions = new("everyone", 3);

    public AllowedMentionType(string name, int value) : base(name, value)
    {
    }
}
