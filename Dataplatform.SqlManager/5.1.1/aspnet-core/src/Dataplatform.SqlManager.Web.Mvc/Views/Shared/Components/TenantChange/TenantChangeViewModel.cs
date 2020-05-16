using Abp.AutoMapper;
using Dataplatform.SqlManager.Sessions.Dto;

namespace Dataplatform.SqlManager.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
