using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace FargoCP.LocalizationPatch
{
    public class Utility : ModSystem
    {
        public static class FSDLC
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("FargosSoulsModDLCRecreated");
                }

            }
            public static ModItem Item(string itemname)
            {

                ModItem item = ModLoader.GetMod("FargosSoulsModDLCRecreated").Find<ModItem>(itemname);
                return item;

            }

        }
        public static class Cal
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("CalamityMod");
                }
            }
            public static Mod Mod
            {
                get
                {
                    return ModLoader.GetMod("CalamityMod");
                }
            }
        }
        public static class Thor
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("ThoriumMod");
                }
            }
            public static Mod Mod
            {
                get
                {
                    return ModLoader.GetMod("ThoriumMod");
                }
            }
        }
        public static class Calbard
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("CalamityBardHealer");
                }
            }
            public static Mod Mod
            {
                get
                {
                    return ModLoader.GetMod("CalamityBardHealer");
                }
            }
        }
        public static class Spi
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("SpiritMod");
                }
            }
            public static Mod Mod
            {
                get
                {
                    return ModLoader.GetMod("SpiritMod");
                }
            }

        }

        public static class FargoCross
        {
            public static bool Load
            {
                get
                {
                    return ModLoader.HasMod("FargowiltasCrossmod");
                }
            }
        }

    }
}
