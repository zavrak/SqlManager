using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Dataplatform.SqlManager.Authorization.Roles;
using Dataplatform.SqlManager.Authorization.Users;
using Dataplatform.SqlManager.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace Dataplatform.SqlManager.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
