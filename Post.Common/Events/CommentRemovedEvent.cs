using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class CommentRemovedEvent : BaseEvent
    {
        public CommentRemovedEvent() : base(nameof(CommentRemovedEvent))
        {
        }

        public string CommentId { get; set; }
        public DateTime DateRemoved { get; set; }
        public string UserName { get; set; }
    }
}