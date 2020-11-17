using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MovieMVC.Authorization;

namespace MovieMVC
{
    [DependsOn(
        typeof(MovieMVCCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MovieMVCApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MovieMVCAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MovieMVCApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
