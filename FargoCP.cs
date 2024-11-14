using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using TigerForceLocalizationLib;

namespace FargoCP
{
    public class FargoCP : Mod
	{
        public override void PostSetupContent()
        {
            TigerForceLocalizationHelper.LocalizeAll("FargoCP", "BannerBoost", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "GodMode", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "MasomodeEX", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "PaperMarioBadgeMod", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "Satanist", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "DirtCraft", true);
            // TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargowiltasCrossmod", true);
        }
        public static Type gmod = null;
	}

	public class World : ModPlayer
	{
        public override void OnEnterWorld()
        {
			if(FargoCP.gmod != null)
			{
                Main.NewText(FargoCP.gmod.Name);
			}
			else
			{
				Main.NewText("¿ÕµÄ");
			}
			
            base.OnEnterWorld();
        }
    }
}
