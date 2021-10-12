using Volo.Abp.Settings;

namespace FirstSocial.Settings
{
    public class FirstSocialSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FirstSocialSettings.MySetting1));
        }
    }
}
