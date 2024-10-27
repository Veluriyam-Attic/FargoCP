using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.PaperMarioBadgeMod.GlobalTranslation
{
    [JITWhenModsEnabled ("PaperMarioBadgeMod")]
    public class PaperMarioBadgeModGlobalTranslation : ModSystem
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
            //勋章槽位
            text = Regex.Replace(text, "Badge Slot:", " 勋章栏位:");
            text = Regex.Replace(text, "BP left", "勋章点数剩余");
            text = Regex.Replace(text, "BP required to equip", "勋章点数才可装备");
            text = Regex.Replace(text, "BP", "勋章点数");

            return orig.Invoke(text, baseColor);
        }       
    }
}
