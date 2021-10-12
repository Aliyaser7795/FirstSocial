using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FirstSocial.Data;
using Volo.Abp.DependencyInjection;

namespace FirstSocial.EntityFrameworkCore
{
    public class EntityFrameworkCoreFirstSocialDbSchemaMigrator
        : IFirstSocialDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFirstSocialDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FirstSocialDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FirstSocialDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
