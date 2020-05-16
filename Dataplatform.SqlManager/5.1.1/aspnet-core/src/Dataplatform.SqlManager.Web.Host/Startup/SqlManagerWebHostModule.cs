using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dataplatform.SqlManager.Configuration;

namespace Dataplatform.SqlManager.Web.Host.Startup
{
    [DependsOn(
       typeof(SqlManagerWebCoreModule))]
    public class SqlManagerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SqlManagerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SqlManagerWebHostModule).GetAssembly());
        }
    }
}
