using System;
using System.Collections.Generic;
using System.Text;
using FirstSocial.Localization;
using Volo.Abp.Application.Services;

namespace FirstSocial
{
    /* Inherit your application services from this class.
     */
    public abstract class FirstSocialAppService : ApplicationService
    {
        protected FirstSocialAppService()
        {
            LocalizationResource = typeof(FirstSocialResource);
        }
    }
}
