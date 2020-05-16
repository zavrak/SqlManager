using Abp.AutoMapper;
using Dataplatform.SqlManager.Authentication.External;

namespace Dataplatform.SqlManager.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
