using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
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
    // DLC传颂之物和血月天塔柱的修改
    public class FargowiltasCrossmod : ModSystem
    {
        //public static Condition condition =
        //new Condition(Language.GetOrRegister(Guid.NewGuid().ToString(), () => "血月天塔柱"), () => Main.player[Main.myPlayer].adjTile[480]);
        //public override void PostAddRecipes()
        //{
        //    _ = Main.recipe
        //        .Where(r => r.HasTile(480))
        //        .Select(r => {
        //            r.RemoveTile(480);
        //            r.AddCondition(condition);
        //            return 1;
        //        })
        //        .ToArray()
        //        ;
        //    base.PostAddRecipes();
        //}

        //javidpack写的解决血月天塔柱翻译的码
        public override void Load()
        {
            Lang._mapLegendCache[MapHelper.TileToLookup(TileID.BloodMoonMonolith, 0)] = Lang.GetItemName(ItemID.BloodMoonMonolith);
        }

        public override void Unload()
        {
            Lang._mapLegendCache[MapHelper.TileToLookup(TileID.BloodMoonMonolith, 0)] = LocalizedText.Empty;
        }


        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("FargowiltasCrossmod")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargowiltasCrossmod", false);
        }
    }

    // 取消那个√石非官方额外魔石的硬编码翻译
    public class FargosSoulsModDLCRecreated : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("FargosSoulsModDLCRecreated")
               )
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargosSoulsModDLCRecreated", false);
        }
    }
}
