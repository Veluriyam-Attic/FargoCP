using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FargoCP.LocalizationPatch
{
    public class LocalizationFix:GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override bool IsLoadingEnabled(Mod mod)
        {
            return Utility.FSDLC.Load;
        }

        public TooltipLine TooltipsPatch(string text, string modName)
        {
            var tooltip = new TooltipLine(Mod, "TooltipPatch", "");
            switch (modName)
            {
                case "cal":
                    tooltip.Text = Language.GetTextValue("Mods.FargoCP.FargosSoulsModDLCRecreated.ItemTooltips.Calamity." + text);
                    return tooltip;
                case "thor":
                    tooltip.Text = Language.GetTextValue("Mods.FargoCP.FargosSoulsModDLCRecreated.ItemTooltips.Thorium." + text);
                    return tooltip;
                case "spi":
                    tooltip.Text = Language.GetTextValue("Mods.FargoCP.FargosSoulsModDLCRecreated.ItemTooltips.Spirit." + text);
                    return tooltip;
                case "noFargoCross":
                    tooltip.Text = Language.GetTextValue("Mods.FargoCP.FargosSoulsModDLCRecreated.ItemTooltips.FargoSouls." + text);
                    return tooltip;
                default:
                    return null;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            //原版物品跳出判断，避免栈溢出
            if (item.ModItem == null) 
            {
                return;
            }

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

            
            if (Utility.FSDLC.Load && Utility.Cal.Load)
            {
                string cal = "cal";
                
                #region 魔石

                //星幻魔石
                if (item.type == Utility.FSDLC.Item("AstralEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("AstralEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("AstralEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("AstralEnchant" + ".Tail", cal));
                    }
                }

                //渊泉魔石
                if (item.type == Utility.FSDLC.Item("AtaxiaEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("AtaxiaEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("AtaxiaEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("AtaxiaEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("AtaxiaEnchant" + ".Tail", cal));
                    }
                }

                //圣金源魔石
                if (item.type == Utility.FSDLC.Item("AuricEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("AuricEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("AuricEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("AuricEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("AuricEnchant" + ".Tail", cal));
                    }
                }

                //血炎魔石
                if (item.type == Utility.FSDLC.Item("BloodflareEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("BloodflareEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("BloodflareEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("BloodflareEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("BloodflareEnchant" + ".Tail", cal));
                    }

                }

                //代达罗斯魔石
                if (item.type == Utility.FSDLC.Item("DaedalusEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("DaedalusEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("DaedalusEnchant" + ".Calbard", cal));
                    }
                    tooltips.Add(TooltipsPatch("DaedalusEnchant" + ".Tail", cal));
                }


                //皇天魔石
                if (item.type == Utility.FSDLC.Item("EmpyreanEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("EmpyreanEnchant" + ".Main", cal));
                    tooltips.Add(TooltipsPatch("EmpyreanEnchant" + ".Tail", cal));
                }

                //幻海鱼群魔石
                if (item.type == Utility.FSDLC.Item("FathomSwarmerEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("FathomSwarmerEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("FathomSwarmerEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("FathomSwarmerEnchant" + ".Tail", cal));
                    }
                }

                //神惧者魔石
                if (item.type == Utility.FSDLC.Item("FearmongerEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("FearmongerEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("FearmongerEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("FearmongerEnchant" + ".Tail", cal));
                    }
                }

                //天钻魔石
                if (item.type == Utility.FSDLC.Item("GemTechEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("GemTechEnchant" + ".Main", cal));
                }

                //弑神者魔石
                if (item.type == Utility.FSDLC.Item("GodSlayerEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("GodSlayerEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("GodSlayerEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("GodSlayerEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("GodSlayerEnchant" + ".Tail", cal));
                    }
                }

                //蓝色欧米茄魔石
                if (item.type == Utility.FSDLC.Item("OmegaBlueEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("OmegaBlueEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("OmegaBlueEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("OmegaBlueEnchant" + ".Tail", cal));
                    }

                }

                //瘟疫使者魔石
                if (item.type == Utility.FSDLC.Item("PlaguebringerEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("PlaguebringerEnchant" + ".Main", cal));
                }

                //瘟疫死神魔石
                if (item.type == Utility.FSDLC.Item("PlagueReaperEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("PlagueReaperEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("PlagueReaperEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("PlagueReaperEnchant" + ".Tail", cal));
                    }
                }

                //始源林海魔石
                if (item.type == Utility.FSDLC.Item("SilvaEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("SilvaEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("SilvaEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("SilvaEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("SilvaEnchant" + ".Tail", cal));
                    }
                }

                //斯塔提斯魔石
                if (item.type == Utility.FSDLC.Item("StatigelEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("StatigelEnchant" + ".Main", cal));
                    tooltips.Add(TooltipsPatch("StatigelEnchant" + ".Tail", cal));
                }

                //硫磺魔石
                if (item.type == Utility.FSDLC.Item("SulphurousEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("SulphurousEnchant" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("SulphurousEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("SulphurousEnchant" + ".Tail", cal));
                    }
                }

                //龙蒿魔石
                if (item.type == Utility.FSDLC.Item("TarragonEnchant").Type)
                {
                    tooltips.Add(TooltipsPatch("TarragonEnchant" + ".Main", cal));
                    if (Utility.Calbard.Load)
                    {
                        tooltips.Add(TooltipsPatch("TarragonEnchant" + ".Calbard", cal));
                    }
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch("TarragonEnchant" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch("TarragonEnchant" + ".Tail", cal));
                    }
                }
                #endregion

                #region 力和魂

                string forces = "Forces."; //本地化文本专门分了灾厄的力和魂，这里要特殊处理一下

                //湮灭之力
                if (item.type == Utility.FSDLC.Item("AnnihilationForce").Type)
                {
                    tooltips.Add(TooltipsPatch(forces + "AnnihilationForce" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch(forces+"AnnihilationForce" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch(forces + "AnnihilationForce" + ".Tail", cal));
                    }
                }

                //荒芜之力
                if (item.type == Utility.FSDLC.Item("DesolationForce").Type)
                {
                    tooltips.Add(TooltipsPatch(forces + "DesolationForce" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch(forces + "DesolationForce" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch(forces + "DesolationForce" + ".Tail", cal));
                    }
                }

                //毁灭之力
                if (item.type == Utility.FSDLC.Item("DevastationForce").Type)
                {
                    tooltips.Add(TooltipsPatch(forces + "DevastationForce" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch(forces + "DevastationForce" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch(forces + "DevastationForce" + ".Tail", cal));
                    }
                }

                //升华之力
                if (item.type == Utility.FSDLC.Item("ExaltationForce").Type)
                {
                    tooltips.Add(TooltipsPatch(forces + "ExaltationForce" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch(forces + "ExaltationForce" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch(forces + "ExaltationForce" + ".Tail", cal));
                    }
                }

                //暴君之魂
                if (item.type == Utility.FSDLC.Item("CalamitySoul").Type)
                {
                    tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".Armor", cal));
                    if (ModLoader.HasMod("CalamityEntropy") &&
                        ModLoader.HasMod("CalamityHunt") &&
                        ModLoader.HasMod("CatalystMod") &&
                        ModLoader.HasMod("Clamity"))
                    {
                        tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".AddonArmor", cal));
                    }
                    tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".Main", cal));
                    if (Utility.FargoCross.Load)
                    {
                        tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".FargoCross", cal));
                    }
                    else
                    {
                        tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".NoFargoCross", cal));
                    }
                    if (ModLoader.HasMod("CalamityEntropy") &&
                        ModLoader.HasMod("CalamityHunt") &&
                        ModLoader.HasMod("CatalystMod") &&
                        ModLoader.HasMod("Clamity"))
                    {
                        tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".AddonAccessory", cal));
                    }
                    tooltips.Add(TooltipsPatch(forces + "CalamitySoul" + ".Tail", cal));
                }
                #endregion
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
                    tooltips.Add(TooltipsPatch("ThoriumSoul" + ".Main", thor));
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
                    tooltips.Add(TooltipsPatch("SpiritSoul" + ".Main", spi));
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
