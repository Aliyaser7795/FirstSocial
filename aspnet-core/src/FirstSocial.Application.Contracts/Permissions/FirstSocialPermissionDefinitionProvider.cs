using FirstSocial.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FirstSocial.Permissions
{
    public class FirstSocialPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FirstSocialPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(FirstSocialPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FirstSocialResource>(name);
        }
    }
}
