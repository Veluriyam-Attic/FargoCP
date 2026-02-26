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
using Terraria.UI;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;
using VeluriyamLibHjson.Destroyer;

namespace FargoCP
{
    public class TigerLibStuffs : ModSystem
    {
        private readonly string[] _names = new string[] { "GodMode", "BannerBoost", "PaperMarioBadgeMod", "FargowiltasCrossmod", "FargosSoulsModDLCRecreated", "CJsAssortedEnchantments" };

        public override void PostSetupContent()
        {
            foreach (var item in _names)
            {
                if(!ModLoader.HasMod(item)) continue;
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", item, false);
            }
            
        }
    }
    // DLC传颂之物和血月天塔柱的修改
    public class FargowiltasCrossmod : ModSystem
    {
        //javidpack写的解决血月天塔柱翻译的码
        //后续可能移除，此事已经在dlc提交pr，并且在tModLoader仓库发了issue
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
                TigerForceLocalizationHelper.LocalizeAll("FargoCP", "FargowiltasCrossmod", false, filters: new()
                { 
                    MethodFilter = MethodFilter.MatchName("DrawExoMechLore")
                });
        }
    }

    public class FargoCP : Mod
    {
    }
}
