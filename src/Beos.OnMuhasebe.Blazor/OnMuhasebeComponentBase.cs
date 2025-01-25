using Beos.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Beos.OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
