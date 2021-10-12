using System.Threading.Tasks;

namespace FirstSocial.Data
{
    public interface IFirstSocialDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
