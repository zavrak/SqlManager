using System.Threading.Tasks;
using Abp.Application.Services;
using Dataplatform.SqlManager.Sessions.Dto;

namespace Dataplatform.SqlManager.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
