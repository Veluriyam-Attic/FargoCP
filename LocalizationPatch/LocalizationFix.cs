using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static FargoCP.LocalizationPatch.Utility;

namespace FargoCP.LocalizationPatch
{
    [JITWhenModsEnabled("FargowiltasCrossmod", "CalamityBardHealer")]
    public class LocalizationFix:GlobalItem
    {
        private readonly List<string> CalEnchant = [
            "AstralEnchant","AtaxiaEnchant","AuricEnchant","BloodflareEnchant","DaedalusEnchant",
            "EmpyreanEnchant","FathomSwarmerEnchant","FearmongerEnchant","GemTechEnchant","GodSlayerEnchant",
            "OmegaBlueEnchant","PlaguebringerEnchant","PlagueReaperEnchant","SilvaEnchant","StatigelEnchant",
            "SulphurousEnchant","TarragonEnchant"];

        private readonly List<string> CalForce = ["AnnihilationForce", "DesolationForce", "DevastationForce", "ExaltationForce"];

        public override bool InstancePerEntity => true;

        public override bool IsLoadingEnabled(Mod mod)
        {
            return Utility.FSDLC.Load;
        }

        public TooltipLine TooltipsPatch(string text, string modName)
        {
            var tooltip = new TooltipLine(Mod, "TooltipPatch", "");
            var rounite = "Mods.FargoCP.FargosSoulsModDLCRecreated.ItemTooltips.";

            if (modName == "cal" && Language.Exists(rounite + "Calamity." + text))
            {
                tooltip.Text = Language.GetTextValue(rounite + "Calamity." + text);
                return tooltip;
            }
            else if (modName == "thor" && Language.Exists(rounite + "Thorium." + text))
            {
                tooltip.Text = Language.GetTextValue(rounite + "Thorium." + text);
                return tooltip;
            }
            else if (modName == "spi" && Language.Exists(rounite + "Spirit." + text))
            {
                tooltip.Text = Language.GetTextValue(rounite + "Spirit." + text);
                return tooltip;
            }
            else if (modName == "noFargoCross" && Language.Exists(rounite + "FargoSouls." + text))
            {
                tooltip.Text = Language.GetTextValue(rounite + "FargoSouls." + text);
                return tooltip;
            }
            else return null;
        }

        //文本插入泰拉瑞亚自带文本前
        public void InsertTooltips(List<TooltipLine> tooltips, TooltipLine tooltip,ref int index , bool firstline = false) 
        {
            if (firstline) index = tooltips.FindIndex(t => t.Name == "Tooltip0" && t.Mod == "Terraria");
            tooltips.Insert(index, tooltip);
            index++;
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            //原版物品和其他模组物品跳出判断，避免栈溢出
            if (item.ModItem == null || item.ModItem.Mod.Name != "FargosSoulsModDLCRecreated") return;


            //删除原模组的文本
            if (item.ModItem.Mod.Name == "FargosSoulsModDLCRecreated" && item.ModItem !=null)
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Mod == "FargosSoulsModDLCRecreated")
                    {
                        tooltip.Hide();
                    }
                }
            }

            #region 灾厄

            //遍历所有魔石 和 力
            if (Utility.FSDLC.Load && Utility.Cal.Load)
            {
                string cal = "cal";
                string forces = "Forces."; //本地化文本专门分了灾厄的力和魂，这里要特殊处理一下
                foreach (var target in CalEnchant) 
                {
                    if (item.type == Utility.FSDLC.Item(target).Type) 
                    {
                        
                        var calbardText = TooltipsPatch(target + ".Calbard", cal);
                        var tailText = TooltipsPatch(target + ".Tail", cal);
                        var fargoText = TooltipsPatch(target + ".FargoCross", cal);

                        
                        int calindex = 0;

                        InsertTooltips(tooltips, TooltipsPatch(target + ".Main", cal),ref calindex,true);
                        if (Utility.Calbard.Load && calbardText != null) 
                        {
                            InsertTooltips(tooltips, calbardText, ref calindex);
                        }
                        if (Utility.FargoCross.Load && fargoText != null)
                        {
                            InsertTooltips(tooltips, fargoText, ref calindex);
                        }
                        else if (tailText != null)
                        {
                            InsertTooltips(tooltips, tailText, ref calindex);
                        }
                    }
                }

                foreach (var target in CalForce) 
                {
                    if (item.type == Utility.FSDLC.Item(target).Type)
                    {
                        var forceTailtext = TooltipsPatch(forces + target + ".Tail", cal);
                        var forceFargotext = TooltipsPatch(forces + target + ".FargoCross", cal);

                        int calindex2 = 0;

                        InsertTooltips(tooltips, TooltipsPatch(forces + target + ".Main", cal),ref calindex2,true);
                        if (Utility.FargoCross.Load && forceFargotext != null)
                        {
                            InsertTooltips(tooltips, forceFargotext, ref calindex2);
                        }
                        else if (forceTailtext != null)
                        {
                            InsertTooltips(tooltips, forceTailtext, ref calindex2);
                        }
                    }
                }

                //暴君之魂
                if (item.type == Utility.FSDLC.Item("CalamitySoul").Type)
                {
                    int calindex3 = 0;

                    InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".Armor", cal),ref calindex3,true);
                    if (ModLoader.HasMod("CalamityEntropy") &&
                        ModLoader.HasMod("CalamityHunt") &&
                        ModLoader.HasMod("CatalystMod") &&
                        ModLoader.HasMod("Clamity"))
                    {
                        InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".AddonArmor", cal), ref calindex3);
                    }
                    InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".Main", cal), ref calindex3);
                    if (Utility.FargoCross.Load)
                    {
                        InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".FargoCross", cal), ref calindex3);
                    }
                    else
                    {
                        InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".NoFargoCross", cal), ref calindex3);
                    }
                    if (ModLoader.HasMod("CalamityEntropy") &&
                        ModLoader.HasMod("CalamityHunt") &&
                        ModLoader.HasMod("CatalystMod") &&
                        ModLoader.HasMod("Clamity"))
                    {
                        InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".AddonAccessory", cal), ref calindex3);
                    }
                    InsertTooltips(tooltips, TooltipsPatch(forces + "CalamitySoul" + ".Tail", cal), ref calindex3);
                }
            }

            #endregion

            #region 瑟银

            if (Utility.Thor.Load && Utility.FSDLC.Load)
            {
                string thor = "thor";

                //颂歌之魂
                if (item.type == Utility.FSDLC.Item("BardSoul").Type && Utility.Calbard.Load)
                {
                    var text = TooltipsPatch("BardSoul" + ".Calbard", thor);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“一乐一天地”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //护使之魂
                if (item.type == Utility.FSDLC.Item("GuardianAngelsSoul").Type && Utility.Calbard.Load)
                {
                    var text = TooltipsPatch("GuardianAngelsSoul" + ".Calbard", thor);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“神圣干预”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //世界树之魂
                if (item.type == Utility.FSDLC.Item("ThoriumSoul").Type)
                {
                    int index = 0;
                    InsertTooltips(tooltips, TooltipsPatch("ThoriumSoul" + ".Main", thor), ref index, true);
                }
            }
            #endregion

            #region 魂灵

            //幻象之魂
            if (Utility.FSDLC.Load && Utility.Spi.Load)
            {
                string spi = "spi";
                if (item.type == Utility.FSDLC.Item("SpiritSoul").Type)
                {
                    int index = 0;
                    InsertTooltips(tooltips, TooltipsPatch("SpiritSoul" + ".Main", spi), ref index, true);
                }
            }
            #endregion

            #region Fargo魂

            //删除Fargo魂里的原模组文本
            if (item.ModItem.Mod.Name == "FargowiltasSouls" && item.ModItem != null && ModLoader.HasMod("FargowiltasSouls"))
            {
                foreach (TooltipLine tooltip in tooltips)
                {
                    if (tooltip.Mod == "FargosSoulsModDLCRecreated")
                    {
                        tooltip.Hide();
                    }
                }
            }


            if (Utility.FSDLC.Load && Utility.Cal.Load && !Utility.FargoCross.Load)
            {
                string noFargoCross = "noFargoCross";

                //巫师之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("ArchWizardsSoul").Type)
                {
                    var text = TooltipsPatch("ArchWizardsSoul",noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“奥术之力，合核凝一”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //狂战士之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("BerserkerSoul").Type)
                {
                    var text = TooltipsPatch("BerserkerSoul",noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“吾之传说生者弗能传颂”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //巨像之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("ColossusSoul").Type)
                {
                    var text = TooltipsPatch("ColossusSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“你无人可挡”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //召唤之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("ConjuristsSoul").Type)
                {
                    var text = TooltipsPatch("ConjuristsSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“一支听命于您的军队”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //维度之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("DimensionSoul").Type)
                {
                    var text = TooltipsPatch("DimensionSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“泰拉瑞亚的维度触手可及”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //神枪手之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("SnipersSoul").Type)
                {
                    var text = TooltipsPatch("SnipersSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“预备，瞄准，开火”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //超音速之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("SupersonicSoul").Type)
                {
                    var text = TooltipsPatch("SupersonicSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“我就是速度”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //捕鱼之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("TrawlerSoul").Type)
                {
                    var text = TooltipsPatch("TrawlerSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“愿者上钩”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }

                //寰宇之魂
                if (item.type == ModLoader.GetMod("FargowiltasSouls").Find<ModItem>("UniverseSoul").Type)
                {
                    var text = TooltipsPatch("UniverseSoul", noFargoCross);
                    int index = tooltips.FindIndex((t) => t.Text.Contains("“诸天也向你俯首”"));
                    if (index != -1)
                    {
                        tooltips.Insert(index, text);
                    }
                }
            }
            #endregion
        }
    }
}
