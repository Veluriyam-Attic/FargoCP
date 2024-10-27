using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace FargoCP
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class FargoCP : Mod
	{
		public static Type gmod = null;
	}

	public class World : ModPlayer
	{
        public override void OnEnterWorld()
        {
			if(FargoCP.gmod != null)
			{
                Main.NewText(FargoCP.gmod.Name);
			}
			else
			{
				Main.NewText("¿ÕµÄ");
			}
			
            base.OnEnterWorld();
        }
    }
}
