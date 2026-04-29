using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace FargoCP.Common
{
    public class FargoCPPlayer : ModPlayer
    {
        public override void OnEnterWorld()
        {
            //Main.NewText(Language.GetTextValue("Mods.FargoCP.OnEnterWorldText",this.Mod.DisplayName));
            InGameNotificationsTracker.AddNotification(new EnterWorldNotification());
        }
    }
}