using BlogApp.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class BlogContext : IdentityDbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Comment>()
                .HasMany(c => c.ChildComments)
                .WithOne(pc => pc.ParentComment)
                .HasForeignKey(pc => pc.CommentId);

            builder.Entity<LikeComment>()
                .HasKey(c => new { c.CommentId, c.UserId });

            builder.Entity<LikePost>()
                .HasKey(c => new { c.PostId, c.UserId });
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<LikePost> LikesPost { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<LikeComment> LikesComment { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
