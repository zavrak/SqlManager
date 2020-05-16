using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dataplatform.SqlManager.Configuration;
using Dataplatform.SqlManager.EntityFrameworkCore;
using Dataplatform.SqlManager.Migrator.DependencyInjection;

namespace Dataplatform.SqlManager.Migrator
{
    [DependsOn(typeof(SqlManagerEntityFrameworkModule))]
    public class SqlManagerMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SqlManagerMigratorModule(SqlManagerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SqlManagerMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SqlManagerConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SqlManagerMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
