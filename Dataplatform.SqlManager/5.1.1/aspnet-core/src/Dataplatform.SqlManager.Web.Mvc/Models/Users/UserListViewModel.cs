using System.Collections.Generic;
using Dataplatform.SqlManager.Roles.Dto;
using Dataplatform.SqlManager.Users.Dto;

namespace Dataplatform.SqlManager.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
