using System.Collections.Generic;
using Dataplatform.SqlManager.Roles.Dto;

namespace Dataplatform.SqlManager.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}