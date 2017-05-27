using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using FirstABP.Persons;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Abp.Web;

namespace FirstABP.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(FirstABPApplicationModule))]
    public class FirstABPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(FirstABPApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder.For<IPersonAppService>("firstabp/person")
                .ForMethod("GetList").WithVerb(HttpVerb.Get)
                .Build();
            //DynamicApiControllerBuilder.For<IPersonAppService>("ChargeStationAPI/City").Build();

            //DynamicApiControllerBuilder
            //    .ForAll<IApplicationService>(Assembly.GetAssembly(typeof(FirstABPApplicationModule)), "tasksystem")
            //    .Build();
        }
    }
}
