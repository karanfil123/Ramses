using Microsoft.EntityFrameworkCore;
using RamsesDataAccess.FluentApi;
using RamsesEntities.Concrete;

namespace RamsesDataAccess.Concrete.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ISMAIL; Database=RamsesDb; Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new WriterMap());
            modelBuilder.ApplyConfiguration(new SubscribeMap());
            modelBuilder.ApplyConfiguration(new BlogRaytingMap());
            modelBuilder.ApplyConfiguration(new MessageMap());

            modelBuilder.Entity<Message2>().HasOne(x => x.SenderUser).WithMany(x => x.MessageSender).HasForeignKey(x => x.SenderID).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Message2>().HasOne(x => x.ReceiverUser).WithMany(x => x.MessageReceiver).HasForeignKey(x => x.ReceiverID).OnDelete(DeleteBehavior.ClientSetNull);
           
        }
    }
}
