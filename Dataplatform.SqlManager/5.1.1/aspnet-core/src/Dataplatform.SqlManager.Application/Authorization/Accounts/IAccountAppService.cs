using System.Threading.Tasks;
using Abp.Application.Services;
using Dataplatform.SqlManager.Authorization.Accounts.Dto;

namespace Dataplatform.SqlManager.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
