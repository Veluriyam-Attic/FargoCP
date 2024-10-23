using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.GodMode.GlobalTranslation
{
    public class GodModeGlobalTranslation : ModSystem
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
            //地图传送长按鼠标时文本
            text = Regex.Replace(text, "Release to teleport", "释放以传送");

            return orig.Invoke(text, baseColor);
        }       
    }
}
