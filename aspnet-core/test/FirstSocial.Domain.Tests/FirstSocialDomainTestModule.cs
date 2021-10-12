using FirstSocial.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FirstSocial
{
    [DependsOn(
        typeof(FirstSocialEntityFrameworkCoreTestModule)
        )]
    public class FirstSocialDomainTestModule : AbpModule
    {

    }
}