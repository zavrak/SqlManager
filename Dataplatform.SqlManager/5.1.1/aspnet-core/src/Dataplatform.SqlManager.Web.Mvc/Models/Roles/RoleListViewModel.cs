using System.Collections.Generic;
using Dataplatform.SqlManager.Roles.Dto;

namespace Dataplatform.SqlManager.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
