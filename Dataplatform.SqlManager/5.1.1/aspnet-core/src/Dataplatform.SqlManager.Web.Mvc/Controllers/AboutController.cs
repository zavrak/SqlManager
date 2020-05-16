using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dataplatform.SqlManager.Controllers;

namespace Dataplatform.SqlManager.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SqlManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
