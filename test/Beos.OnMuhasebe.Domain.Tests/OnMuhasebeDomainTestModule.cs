using Volo.Abp.Modularity;

namespace Beos.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeDomainModule),
    typeof(OnMuhasebeTestBaseModule)
)]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
