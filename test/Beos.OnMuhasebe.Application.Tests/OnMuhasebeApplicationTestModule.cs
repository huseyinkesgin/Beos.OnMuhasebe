using Volo.Abp.Modularity;

namespace Beos.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeApplicationModule),
    typeof(OnMuhasebeDomainTestModule)
)]
public class OnMuhasebeApplicationTestModule : AbpModule
{

}
