using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dataplatform.SqlManager.Web.Views
{
    public abstract class SqlManagerViewComponent : AbpViewComponent
    {
        protected SqlManagerViewComponent()
        {
            LocalizationSourceName = SqlManagerConsts.LocalizationSourceName;
        }
    }
}
