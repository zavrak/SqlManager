using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dataplatform.SqlManager.Configuration;

namespace Dataplatform.SqlManager.Web.Startup
{
    [DependsOn(typeof(SqlManagerWebCoreModule))]
    public class SqlManagerWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SqlManagerWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SqlManagerNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SqlManagerWebMvcModule).GetAssembly());
        }
    }
}
