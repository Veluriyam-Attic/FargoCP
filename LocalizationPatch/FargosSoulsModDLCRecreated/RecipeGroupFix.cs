using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace FargoCP.LocalizationPatch.FargosSoulsModDLCRecreated
{
    public class RecipeGroupFix:ModSystem
    {
        private static Dictionary<string, string> recipeGroup= new()
        {
            //灾厄
            ["AnyAerospecHelmet"] = "天蓝头盔",
            ["AnyHydrothermicHelmet"] = "渊泉头盔",
            ["AnyAuricHelmet"] = "圣金源头盔",
            ["AnyBloodflareHelmet"] = "血炎头盔",
            ["AnyDaedalusHelmet"] = "代达罗斯头盔",
            ["AnyGodslayerHelmet"] = "弑神者头盔",
            ["AnyIntergelacticHelmet"] = "异宇星凝头盔",
            ["AnyReaverHelmet"] = "掠夺者头盔",
            ["AnySilvaHelmet"] = "始源林海头盔",
            ["AnyStatigelHelmet"] = "斯塔提斯头盔",
            ["AnyTarragonHelmet"] = "龙蒿头盔",
            ["AnyVictideHelmet"] = "胜潮头盔",
            ["AnyVoidFaquirHelmet"] = "虚空行者头盔",
            //暗影奥秘
            ["AnyFrigidChestplate"] = "极寒胸甲",
            //瑟银
            ["AnyAssassinHelmet"] = "刺客头盔",
            ["AnyBugleHorn"] = "军号", 
            ["AnyJesterMask"] = "弄臣面具", 
            ["AnyJesterShirt"] = "弄臣服", 
            ["AnyJesterLeggings"] = "弄臣裤", 
            ["AnyLetter"] = "粉丝的信函", 
            ["AnyTambourine"] = "铃鼓", 
            ["AnySpiritTrapperHelmet"] = "猎魂头盔", 
            ["AnyTitanHelmet"] = "泰坦头盔"
        };

        public override bool IsLoadingEnabled(Mod mod)
        {
            return Utility.FSDLC.Load;
        }

        public override void PostAddRecipes()
        {

            foreach (var groupName in recipeGroup) 
            {
                if (groupName.Key == "")
                    continue;

                if (RecipeGroup.recipeGroupIDs.TryGetValue($"FargosSoulsModDLCRecreated:{groupName.Key}", out int groupId))
                {
                    RecipeGroup.recipeGroups[groupId].GetText = () => $"{Language.GetTextValue("LegacyMisc.37")} {groupName.Value}";
                }

            }
        }
    }
}
