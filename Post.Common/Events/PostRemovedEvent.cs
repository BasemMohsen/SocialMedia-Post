using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class PostRemovedEvent : BaseEvent
    {
        public PostRemovedEvent() : base(nameof(PostRemovedEvent))
        {
        }

        public string PostId { get; set; }
        public DateTime DateRemoved { get; set; }
        public string UserName { get; set; }
    }
}