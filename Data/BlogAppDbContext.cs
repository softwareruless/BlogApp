using BlogApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class BlogAppDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<EmailVerification> EmailVerification { get; set; }
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<TagRelation> TagRelation { get; set; }




    }
}
