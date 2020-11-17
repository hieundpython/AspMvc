using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MovieMVC.Configuration;

namespace MovieMVC.Web.Host.Startup
{
    [DependsOn(
       typeof(MovieMVCWebCoreModule))]
    public class MovieMVCWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MovieMVCWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MovieMVCWebHostModule).GetAssembly());
        }
    }
}
