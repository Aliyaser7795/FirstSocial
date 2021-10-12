using FirstSocial.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FirstSocial.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FirstSocialController : AbpController
    {
        protected FirstSocialController()
        {
            LocalizationResource = typeof(FirstSocialResource);
        }
    }
}