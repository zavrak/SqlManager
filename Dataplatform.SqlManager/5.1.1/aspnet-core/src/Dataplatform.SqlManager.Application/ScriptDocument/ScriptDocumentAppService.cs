using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.UI;
using Dataplatform.SqlManager.Authorization;
using Dataplatform.SqlManager.Authorization.Accounts;
using Dataplatform.SqlManager.Authorization.Roles;
using Dataplatform.SqlManager.Authorization.Users;
using Dataplatform.SqlManager.Roles.Dto;
using Dataplatform.SqlManager.ScriptDocument.Dto;
using Dataplatform.SqlManager.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dataplatform.SqlManager.ScriptDocument
{
    public class ScriptDocumentAppService :SqlManagerAppServiceBase, IScriptDocumentAppService
    {
        private readonly IRepository<ScriptDocument> _scriptDocumentRepository;

        public ScriptDocumentAppService(IRepository<ScriptDocument> scriptDocumentRepository)
        {
            _scriptDocumentRepository = scriptDocumentRepository;
        }

        public async Task<ListResultDto<ScriptDocumentDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _scriptDocumentRepository
                .GetAll()
                .WhereIf(input.ScriptType.HasValue, t => t.ScriptType == input.ScriptType.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<ScriptDocumentDto>(
                ObjectMapper.Map<List<ScriptDocumentDto>>(tasks)
            );
        }

   
    }

}

