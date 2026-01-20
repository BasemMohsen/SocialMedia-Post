using CQRS.Core.Events;
using System;

namespace Post.Common.Events
{
    public class PostLikedEvent : BaseEvent
    {
        public PostLikedEvent() : base(nameof(PostLikedEvent))
        {
        }

        //public string Author { get; set; }
        //public DateTime DateLiked { get; set; }
    }
}