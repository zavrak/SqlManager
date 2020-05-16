using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Dataplatform.SqlManager.Web.Views
{
    public abstract class SqlManagerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SqlManagerRazorPage()
        {
            LocalizationSourceName = SqlManagerConsts.LocalizationSourceName;
        }
    }
}
