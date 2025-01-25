using Beos.OnMuhasebe.Samples;
using Xunit;

namespace Beos.OnMuhasebe.EntityFrameworkCore.Domains;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
