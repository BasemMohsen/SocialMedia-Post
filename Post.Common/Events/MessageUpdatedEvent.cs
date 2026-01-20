using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class MessageUpdatedEvent : BaseEvent
    {
        public MessageUpdatedEvent() : base(nameof(MessageUpdatedEvent))
        {
        }

        //public string Author { get; set; }
        public string Message { get; set; }
        //public DateTime DateUpdated { get; set; }
    }
}