using System;
using System.Collections.Generic;

namespace SignalRChat.Data.Models
{
    public class User
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual ICollection<Message> SendMessages { get; set; }
        public virtual ICollection<Message> ReceiveMessages { get; set; }

    }
}