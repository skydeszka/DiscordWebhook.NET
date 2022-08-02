using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhook.Entities.Flags;
public sealed class MessageFlag : SmartEnum<MessageFlag>
{
    public static readonly MessageFlag Crossposted = new("CROSSPOSTED", 1 << 0);
    public static readonly MessageFlag IsCrosspost = new("IS_CROSSPOST", 1 << 1);
    public static readonly MessageFlag SuppressEmbeds = new("SUPRESS_EMBEDS", 1 << 2);
    public static readonly MessageFlag SourceMessageDeleted = new("SOURCE_MESSAGE_DELETED", 1 << 3);
    public static readonly MessageFlag Urgent = new("URGENT", 1 << 4);
    public static readonly MessageFlag HasThread = new("HAS_THREAD", 1 << 5);
    public static readonly MessageFlag Ephemeral = new("EPHEMERAL", 1 << 6);
    public static readonly MessageFlag Loading = new("LOADING", 1 << 7);
    public static readonly MessageFlag FailedToMentionSomeRolesInThread = new("FAILED_TO_MENTION_SOME_ROLES_IN_THREAD", 1 << 8);

    public MessageFlag(string name, int value) : base(name, value)
    {
    }
}
