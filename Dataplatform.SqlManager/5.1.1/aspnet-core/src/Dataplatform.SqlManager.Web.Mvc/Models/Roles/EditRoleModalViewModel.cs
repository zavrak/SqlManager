using Abp.AutoMapper;
using Dataplatform.SqlManager.Roles.Dto;
using Dataplatform.SqlManager.Web.Models.Common;

namespace Dataplatform.SqlManager.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
