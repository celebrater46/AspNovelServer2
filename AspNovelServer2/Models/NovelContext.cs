using Microsoft.EntityFrameworkCore;

namespace AspNovelServer2.Models
{
    public class NovelContext : DbContext

    {
        public NovelContext(DbContextOptions<NovelContext> options) : base(options)
        {
            
        }
        
        public DbSet<Novel> Novels { get; set; }
    }
}