using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRChat.Data.Models
{
    public class Message
    {
        [Key]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SenderId { get; set; }
        public string ReceiverId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        [ForeignKey("SenderId")]
        public virtual User Sender { get; set; }
        [ForeignKey("ReceiverId")]
        public virtual User Receiver { get; set; }
    }
}