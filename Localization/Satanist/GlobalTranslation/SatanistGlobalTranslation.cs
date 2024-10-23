using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.Satanist.GlobalTranslation
{
    public class SatanistGlobalTranslation : ModSystem
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
            //模组配置
            text = Regex.Replace(text, "Max Life Hostile", "修改敌方最大生命值到2,147,483,647");
            text = Regex.Replace(text, "Min Life Friendly", "修改友方生命值为最低（受击即死）");

            return orig.Invoke(text, baseColor);
        }       
    }
}
