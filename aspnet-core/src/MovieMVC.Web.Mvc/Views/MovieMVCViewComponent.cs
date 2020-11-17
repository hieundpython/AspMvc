using Abp.AspNetCore.Mvc.ViewComponents;

namespace MovieMVC.Web.Views
{
    public abstract class MovieMVCViewComponent : AbpViewComponent
    {
        protected MovieMVCViewComponent()
        {
            LocalizationSourceName = MovieMVCConsts.LocalizationSourceName;
        }
    }
}
