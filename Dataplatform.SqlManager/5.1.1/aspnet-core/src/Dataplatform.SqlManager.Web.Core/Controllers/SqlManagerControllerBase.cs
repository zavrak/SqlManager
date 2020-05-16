using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dataplatform.SqlManager.Controllers
{
    public abstract class SqlManagerControllerBase: AbpController
    {
        protected SqlManagerControllerBase()
        {
            LocalizationSourceName = SqlManagerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
