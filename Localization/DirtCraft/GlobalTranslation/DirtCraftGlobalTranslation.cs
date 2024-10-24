using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.DirtCraft.GlobalTranslation
{
    public class DirtCraftGlobalTranslation : ModSystem
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
            text = Regex.Replace(text, "Dirt", "泥土");

            return orig.Invoke(text, baseColor);
        }       
    }
}
