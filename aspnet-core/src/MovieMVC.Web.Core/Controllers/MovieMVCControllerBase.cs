using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MovieMVC.Controllers
{
    public abstract class MovieMVCControllerBase: AbpController
    {
        protected MovieMVCControllerBase()
        {
            LocalizationSourceName = MovieMVCConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
