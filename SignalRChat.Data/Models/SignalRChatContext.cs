using System.Data.Entity;

namespace SignalRChat.Data.Models
{
    public class SignalRChatContext : DbContext
    {
        public SignalRChatContext():base(AppSetting.ConnectionString)
        {
            
        }
        protected DbSet<User> Users { get; set; }
        protected DbSet<Message> Messages { get; set; }
    }
}