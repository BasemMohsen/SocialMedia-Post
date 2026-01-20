using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class CommentAddedEvent : BaseEvent
    {
        public CommentAddedEvent() : base(nameof(CommentAddedEvent))
        {
        }

        public string CommentId { get; set; }
        //public string PostId { get; set; }
        //public string Author { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public string UserName { get; set; }
    }
}