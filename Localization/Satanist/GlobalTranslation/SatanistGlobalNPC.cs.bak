using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using static System.Net.Mime.MediaTypeNames;

namespace FargoCP.Localization.Satanist.GlobalTranslation
{
    [JITWhenModsEnabled("Satanist")]
    public class SatanistGlobalNPC : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            //至少是永恒+FTW才能触发对话，永恒懒得写了）
            if (!Main.getGoodWorld)
            {
                return;
            }

            //突变体对话
            chat = Regex.Replace(chat, "What you're doing is a crime against the universe, mortal.", "你所做的是对宇宙的犯罪，凡人。");

            //戴薇安对话
            chat = Regex.Replace(chat, "Play a real game mode, would you? Not this... thing.", "玩一个真正的模式，好吗？不是...这个。");

        }
    }
}
