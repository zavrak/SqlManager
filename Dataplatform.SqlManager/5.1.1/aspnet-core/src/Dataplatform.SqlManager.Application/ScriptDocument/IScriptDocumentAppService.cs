using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dataplatform.SqlManager.ScriptDocument.Dto;
using Dataplatform.SqlManager.Users.Dto;

namespace Dataplatform.SqlManager.ScriptDocument
    {
    public interface IScriptDocumentAppService : IApplicationService
    {
        Task<ListResultDto<ScriptDocumentDto>> GetAll(GetAllTasksInput input);
    }

    public class GetAllTasksInput
    {
        public ScriptTypeEnum? ScriptType { get; set; }
    }
}
