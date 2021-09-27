using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace sweet.log.Controllers
{
    public abstract class logControllerBase: AbpController
    {
        protected logControllerBase()
        {
            LocalizationSourceName = logConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
