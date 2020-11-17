using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MovieMVC.Web.Views
{
    public abstract class MovieMVCRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MovieMVCRazorPage()
        {
            LocalizationSourceName = MovieMVCConsts.LocalizationSourceName;
        }
    }
}
