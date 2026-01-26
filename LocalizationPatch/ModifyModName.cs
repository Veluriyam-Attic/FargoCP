using FargoCP.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FargoCP.LocalizationPatch
{
    public class ModifyModName : ModSystem
    {
        private static Dictionary<string, Mod> Mods = new Dictionary<string, Mod>()
        {
            //官方魂系列
            ["FargowiltasMusic"] = null,
            ["FargowiltasSouls"] = null,
            ["Fargowiltas"] = null,
            ["FargowiltasSoulsDLC"] = null,

            //非官方魔石扩展
            ["CJsAssortedEnchantments"] = null,
            ["FargosSoulsModDLCRecreated"] = null,
            ["SuperSoulsDLC"] = null,
            ["FargoSoulMore"] = null,
            ["FargoMoreSoulsCompat"] = null,
            ["ssm"] = null,
            ["FargoThorium"] = null,

            //官方跨模组扩展
            ["FargowiltasCrossmod"] = null,

            //非官方跨模组扩展
            ["FargoClickers"] = null,
            ["FargoUnofficialPets"] = null,
            ["SoulsBossRushMod"] = null,
            ["RadianceSouls"] = null,
            ["CalamityBalancedItemsF"] = null,
            ["fargosoulstweaks"] = null,

            //官方非魔石相关模组
            ["FargoEnemyModifiers"] = null,
            ["FishAnything"] = null,
            ["TooManySlots"] = null,
            ["LootBonus"] = null,
            ["OmniWield"] = null,
            ["FargoSeeds"] = null,
            ["BannerBoost"] = null,
            ["RainbowMod"] = null,
            ["PaperMarioBadgeMod"] = null,
            ["CraftingTreeGenerator"] = null,
            ["StarHell"] = null,
            ["HyperMode"] = null,
            ["GodMode"] = null,
            ["FargosExpertModifs"] = null,

            //官方音乐扩展
            ["TerryMusicMod"] = null,
            ["FargoAltMusicMod"] = null,
        };

        public override void Load()
        {
            foreach (var name in Mods.Keys)
            {
                if (!ModLoader.HasMod(name))
                    continue;
                else
                {
                    Mods[name] = ModLoader.GetMod(name);
                }
            }
        }

        public override void OnLocalizationsLoaded()
        {       
            foreach (var name in Mods.Keys)
            {
                if (Mods[name] is null)
                    continue;
                else
                { 
                    Mods[name].DisplayName = Terraria.Localization.Language.GetTextValue($"Mods.FargoCP.ModName.{name}");
                }
            }
        }

        public override void Unload()
        {
            foreach (var name in Mods.Keys)
            {
                Mods[name] = null;
            }
        }
    }
}
