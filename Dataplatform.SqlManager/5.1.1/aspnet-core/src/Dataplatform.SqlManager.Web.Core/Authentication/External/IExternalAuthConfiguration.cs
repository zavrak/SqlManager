using System.Collections.Generic;

namespace Dataplatform.SqlManager.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
