using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.BannerBoost.GlobalTranslation
{
    public class BannerBoostGlobalTranslation : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }       
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //升级描述
            text = Regex.Replace(text, "Congratulations! You have earned the max Level against", "恭喜！你已经完全免疫");
            text = Regex.Replace(text, "Congratulations! You have reached Level", "恭喜！你已经达到了增幅");
            text = Regex.Replace(text, "against", "级对于");

            return orig.Invoke(text, baseColor);
        }       
    }
}
