using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace FargoCP.Localization.Satanist.GlobalTranslation
{
    [JITWhenModsEnabled("Satanist")]
    public class SatanistGlobalItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            ModLoader.TryGetMod("Satanist",out Mod satanist);
            if (satanist != null)
            {
                //反射拿到模组配置的值
                var config = satanist.GetConfig("SatanistServerConfig");
                var configtype = satanist.Code.GetTypes().First(t => t.Name == "SatanistServerConfig");
                var yoyo = configtype.GetField("<YoyosEnabled>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
                
                //生命水晶
                if (item.type == ItemID.LifeCrystal)
                {
                    var LifeCrystalText = tooltips.Find((l) => l.Name == "Verbose:Satanerf");
                    if (LifeCrystalText != null)
                    {
                        LifeCrystalText.Text = "\"撒旦的能量污染了生命水晶\""
                            + "\n\"有几率减少生命上限\""
                            + "\n\"有几率不完全生效\"";
                    }
                }

                //悠悠球
                if (ItemID.Sets.Yoyo[item.type] && yoyo.GetValue(config).Equals(false))
                {
                    var YoyoText = tooltips.Find((l) => l.Name == "Yoyo" && l.Mod == "Satanist");
                    if (YoyoText != null)
                    {
                        YoyoText.Text = "可疑的";
                    }
                }
                //弹药
                if (item.ammo != 0)
                {
                    var ammoText = tooltips.Find((l) => l.Name == "Verbose:SataNerf");
                    if (ammoText != null)
                    {
                        ammoText.Text = "撒旦的能量削弱了你的弹药";
                    }
                }
            }
            base.ModifyTooltips(item, tooltips);
        }
    }
}
