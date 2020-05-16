using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Dataplatform.SqlManager.Authorization;
using Dataplatform.SqlManager.Controllers;

using Dataplatform.SqlManager.Web.Models.Users;
using Dataplatform.SqlManager.ScriptDocument;
using Dataplatform.SqlManager.Web.Models.ScriptDocument;

namespace Dataplatform.SqlManager.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class ScriptDocumentController : SqlManagerControllerBase
    {
        private readonly IScriptDocumentAppService _scriptDocumentAppService;

        public ScriptDocumentController(IScriptDocumentAppService scriptDocumentAppService)
        {
            _scriptDocumentAppService = scriptDocumentAppService;
        }

        public async Task<ActionResult> Index()
        {
            var records = (await _scriptDocumentAppService.GetAll(new GetAllTasksInput{ ScriptType = null})).Items; //        

            var model = new ScriptDocumentListViewModel(records);
            return View(model);
        }
     
        //public async Task<ActionResult> EditUserModal(long userId)
        //{
        //    var user = await _scriptDocumentAppService.GetAsync(new EntityDto<long>(userId));
        //    var roles = (await _scriptDocumentAppService.GetRoles()).Items;
        //    var model = new EditUserModalViewModel
        //    {
        //        User = user,
        //        Roles = roles
        //    };
        //    return View("_EditUserModal", model);
        //}
    }
}
