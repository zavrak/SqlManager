using System.Collections.Generic;
using System.Linq;
using Dataplatform.SqlManager.Roles.Dto;
using Dataplatform.SqlManager.Users.Dto;

namespace Dataplatform.SqlManager.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
