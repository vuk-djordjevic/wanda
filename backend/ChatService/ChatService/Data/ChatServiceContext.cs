using ChatService.Model;
using ChatService.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatService.Data
{
    public class ChatServiceContext : DbContext
    {
        public ChatServiceContext(DbContextOptions<ChatServiceContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
