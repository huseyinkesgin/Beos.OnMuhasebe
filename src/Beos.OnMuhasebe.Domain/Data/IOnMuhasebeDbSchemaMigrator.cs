using System.Threading.Tasks;

namespace Beos.OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
