using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SuryaVineforceProject.Authorization.Roles;
using SuryaVineforceProject.Authorization.Users;
using SuryaVineforceProject.MultiTenancy;

namespace SuryaVineforceProject.EntityFrameworkCore
{
    public class SuryaVineforceProjectDbContext : AbpZeroDbContext<Tenant, Role, User, SuryaVineforceProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SuryaVineforceProjectDbContext(DbContextOptions<SuryaVineforceProjectDbContext> options)
            : base(options)
        {
        }
    }
}
