using Abp.MultiTenancy;
using SuryaVineforceProject.Authorization.Users;

namespace SuryaVineforceProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
