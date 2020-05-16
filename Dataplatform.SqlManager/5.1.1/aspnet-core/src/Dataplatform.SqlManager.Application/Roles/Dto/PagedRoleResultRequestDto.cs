using Abp.Application.Services.Dto;

namespace Dataplatform.SqlManager.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

