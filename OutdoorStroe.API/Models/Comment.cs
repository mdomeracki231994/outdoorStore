﻿namespace OutdoorStroe.API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
