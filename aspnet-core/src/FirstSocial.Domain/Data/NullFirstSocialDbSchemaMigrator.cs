using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FirstSocial.Data
{
    /* This is used if database provider does't define
     * IFirstSocialDbSchemaMigrator implementation.
     */
    public class NullFirstSocialDbSchemaMigrator : IFirstSocialDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}