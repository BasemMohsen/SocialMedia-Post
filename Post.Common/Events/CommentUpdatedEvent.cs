using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class CommentUpdatedEvent : BaseEvent
    {
        public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
        {
        }

        public string CommentId { get; set; }
        public string UpdatedComment { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UserName { get; set; }
    }
}