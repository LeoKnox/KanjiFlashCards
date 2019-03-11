using Microsoft.EntityFrameworkCore;

namespace FlashCard.Models
{
    public class FlashCardContext : DbContext
    {
        public FlashCardContext(DbContextOptions<FlashCardContext> options) : base(options) {}
        public DbSet<Kanji> Kanjis { get; set; }
    }
}