using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using sweet.log.Authorization.Roles;
using sweet.log.Authorization.Users;
using sweet.log.MultiTenancy;
using sweet.log.Posts;
using sweet.log.Collections;

namespace sweet.log.EntityFrameworkCore
{
    public class logDbContext : AbpZeroDbContext<Tenant, Role, User, logDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Post> Posts { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public logDbContext(DbContextOptions<logDbContext> options)
            : base(options)
        {
        }
    }
}
