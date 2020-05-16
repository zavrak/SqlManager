using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Dataplatform.SqlManager.Authorization.Users;
using Dataplatform.SqlManager.Editions;

namespace Dataplatform.SqlManager.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
