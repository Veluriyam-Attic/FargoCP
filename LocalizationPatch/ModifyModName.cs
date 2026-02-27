using Terraria.ModLoader;
using VeluriyamLibHjson.Core;

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
            ["FargoThorium"] = null,
            ["fargosconfigslop"] = null,

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

        public override void OnLocalizationsLoaded()
        {
            foreach (var name in Mods.Keys)
            {
                VeluriyamLibHjson.Destroyer.ModifyModName.ModifyConfigName(name, VeluriyamLanguage.SafeGetTextValue($"Mods.FargoCP.ModName.{name}"));

                #warning 请记得把该处的反射替换为可以获取对应语言文本的办法
            }
            VeluriyamLibHjson.Destroyer.ModifyModName.ModifyManageModName("Fargo's Mutant Mod", VeluriyamLanguage.SafeGetTextValue($"Mods.FargoCP.ModName.Fargowiltas"));
        }
    }
}
