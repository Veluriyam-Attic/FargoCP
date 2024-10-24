using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace FargoCP.Localization.Satanist.GlobalTranslation
{
    [JITWhenModsEnabled("Satanist")]
    public class SatanistPlayer : ModPlayer
    {
        public override void PreUpdate()
        {
            base.PreUpdate();
        }
        public override void PreUpdateBuffs()
        {
            //Main.NewText($"{Main.getGoodWorld} {Player.lavaWet} {Player.lavaTime}");
            base.PreUpdateBuffs();
        }
        public override void PostUpdateBuffs()
        {
            base.PostUpdateBuffs();
        }
        public override void PostUpdate()
        {
            base.PostUpdate();
        }
    }
}
