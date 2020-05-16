using Abp.MultiTenancy;
using Dataplatform.SqlManager.Authorization.Users;

namespace Dataplatform.SqlManager.MultiTenancy
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
