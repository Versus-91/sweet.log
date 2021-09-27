using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using sweet.log.Authorization.Roles;
using sweet.log.Authorization.Users;
using sweet.log.MultiTenancy;

namespace sweet.log.EntityFrameworkCore
{
    public class logDbContext : AbpZeroDbContext<Tenant, Role, User, logDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public logDbContext(DbContextOptions<logDbContext> options)
            : base(options)
        {
        }
    }
}
