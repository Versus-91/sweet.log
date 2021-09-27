using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sweet.log.Authorization;

namespace sweet.log
{
    [DependsOn(
        typeof(logCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class logApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<logAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(logApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
