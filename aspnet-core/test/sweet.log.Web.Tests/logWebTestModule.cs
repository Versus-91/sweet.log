using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sweet.log.EntityFrameworkCore;
using sweet.log.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace sweet.log.Web.Tests
{
    [DependsOn(
        typeof(logWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class logWebTestModule : AbpModule
    {
        public logWebTestModule(logEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(logWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(logWebMvcModule).Assembly);
        }
    }
}