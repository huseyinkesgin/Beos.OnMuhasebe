using Microsoft.Extensions.Localization;
using Beos.OnMuhasebe.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Beos.OnMuhasebe.Blazor;

[Dependency(ReplaceServices = true)]
public class OnMuhasebeBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OnMuhasebeResource> _localizer;

    public OnMuhasebeBrandingProvider(IStringLocalizer<OnMuhasebeResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
