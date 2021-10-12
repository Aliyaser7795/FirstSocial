using Volo.Abp.Modularity;

namespace FirstSocial
{
    [DependsOn(
        typeof(FirstSocialApplicationModule),
        typeof(FirstSocialDomainTestModule)
        )]
    public class FirstSocialApplicationTestModule : AbpModule
    {

    }
}