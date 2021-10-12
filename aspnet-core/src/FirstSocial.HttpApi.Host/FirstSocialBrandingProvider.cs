using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FirstSocial
{
    [Dependency(ReplaceServices = true)]
    public class FirstSocialBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FirstSocial";
    }
}
