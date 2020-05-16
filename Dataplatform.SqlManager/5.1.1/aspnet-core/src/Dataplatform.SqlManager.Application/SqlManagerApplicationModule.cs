using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dataplatform.SqlManager.Authorization;

namespace Dataplatform.SqlManager
{
    [DependsOn(
        typeof(SqlManagerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SqlManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SqlManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SqlManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
