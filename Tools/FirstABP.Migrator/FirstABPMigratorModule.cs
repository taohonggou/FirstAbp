using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using FirstABP.EntityFramework;

namespace FirstABP.Migrator
{
    [DependsOn(typeof(FirstABPDataModule))]
    public class FirstABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FirstABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}