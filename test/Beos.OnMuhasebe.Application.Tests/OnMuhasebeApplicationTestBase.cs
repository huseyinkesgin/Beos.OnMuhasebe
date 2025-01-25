using Volo.Abp.Modularity;

namespace Beos.OnMuhasebe;

public abstract class OnMuhasebeApplicationTestBase<TStartupModule> : OnMuhasebeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
