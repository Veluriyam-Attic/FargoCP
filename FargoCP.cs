using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;

namespace FargoCP
{
    public class GodMode : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("GodMode")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "GodMode", false);
        }
    }
    public class BannerBoost : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("BannerBoost")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "BannerBoost", false);
        }
    }
    public class PaperMarioBadgeMod : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("PaperMarioBadgeMod")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "PaperMarioBadgeMod", false);
        }
    }
    // 取消对DLC的硬编码翻译
    public class FargowiltasCrossmod : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("FargowiltasCrossmod")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargowiltasCrossmod", false);
        }
    }

    // 取消那个√石非官方额外魔石的硬编码翻译
    /* public class FargosSoulsModDLCRecreated : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("FargosSoulsModDLCRecreated")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargosSoulsModDLCRecreated", false);
        }
    } */

}
