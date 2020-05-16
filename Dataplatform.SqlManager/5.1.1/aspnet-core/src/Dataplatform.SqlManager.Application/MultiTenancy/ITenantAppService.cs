using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dataplatform.SqlManager.MultiTenancy.Dto;

namespace Dataplatform.SqlManager.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

