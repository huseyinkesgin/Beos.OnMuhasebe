﻿using Volo.Abp.Settings;

namespace Beos.OnMuhasebe.Settings;

public class OnMuhasebeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OnMuhasebeSettings.MySetting1));
    }
}
