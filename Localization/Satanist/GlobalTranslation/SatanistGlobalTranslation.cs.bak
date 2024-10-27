using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.Satanist.GlobalTranslation
{
    [JITWhenModsEnabled("Satanist")]
    public class SatanistGlobalTranslation : ModSystem
    {
        public override void Load()
        {
            On_CombatText.NewText_Rectangle_Color_string_bool_bool += CombatTextTranslate;
            On_ChatManager.ParseMessage += NewTextTranslate;
            On_ChatHelper.BroadcastChatMessage += BroadcastTranslate;
            On_PlayerDeathReason.GetDeathText += DeathTextTranslate;
            base.Load();
        }

        public override void Unload()
        {
            On_CombatText.NewText_Rectangle_Color_string_bool_bool -= CombatTextTranslate;
            On_ChatManager.ParseMessage -= NewTextTranslate;
            On_ChatHelper.BroadcastChatMessage -= BroadcastTranslate;
            On_PlayerDeathReason.GetDeathText -= DeathTextTranslate;
            base.Unload();
        }

        private NetworkText DeathTextTranslate(On_PlayerDeathReason.orig_GetDeathText orig, PlayerDeathReason self, string deadPlayerName)
        {
            //玩家死亡信息
            if (self.SourceCustomReason != null)
            {
                string text = self.SourceCustomReason;
                //噬魂者
                text = Regex.Replace(text, " was eaten alive by Eater of Souls.", "被噬魂者活吞了。");

                //毁灭者
                text = Regex.Replace(text, " was eaten alive by The Destroyer.", "被毁灭者活吞了。");

                //胡桃夹子
                text = Regex.Replace(text, " got his nuts cracked.", "的“坚果”裂开了。");

                //1%的几率被NPC暴击，三倍暴击伤害
                text = Regex.Replace(text, " got CRITTED, lol", "被爆头了，乐。");

                //boss战中与护士对话时直接杀死玩家
                text = Regex.Replace(text, " was punished for dishonorable tactics.", "因低级的把戏而受到惩罚。");

                //被向日葵（物块）杀死
                text = Regex.Replace(text, " got PvZed", "在玩我是僵尸");
                text = Regex.Replace(text, " pricked themself", "被刺死了");
                text = Regex.Replace(text, " realized they are allergic", "意识到他对向日葵过敏");
                text = Regex.Replace(text, " ate a petal", "吃了一片花瓣");
                text = Regex.Replace(text, " died to a flower xd", "死于一朵花:)");
                text = Regex.Replace(text, " got bumflowered", "被花朵淹没");

                //被神庙石化
                text = Regex.Replace(text, " was cursed and became a lifeless statue.", "被诅咒变成了一具死寂的雕像。");

                //身上有迈达斯buff
                if (text.StartsWith("At least ") && text.EndsWith(" isn't worthless anymore."))
                {
                    text = Regex.Replace(text, "At least ", "至少");
                    text = Regex.Replace(text, " isn't worthless anymore.", "不再一文不值了。");
                }
                text = Regex.Replace(text, " became a motionless golden statue.", "变成了一具静止的金雕像。");
                text = Regex.Replace(text, " was turned to gold.", "变成了金子。");

                //被正常石化
                text = Regex.Replace(text, "'s flesh was petrified.", "的肉体被石化了。");
                text = Regex.Replace(text, " became a motionless statue.", "变成了一具静止的雕像。");
                text = Regex.Replace(text, " was turned to stone.", "变成了石头。");

                //被时停杀死
                text = Regex.Replace(text, " took too many hits at once.", "一下子承受了太多伤害。");

                //至少永恒 + FTW模式下：
                //不免疫岩浆的情况下接触岩浆会即死
                text = Regex.Replace(text, " was instantly incinerated.", "被瞬间烧成灰烬。");

                //接触树木会受到伤害
                text = Regex.Replace(text, " was pricked by a Tree.", "被树戳穿了。");

                //接触恶魔祭坛会受到伤害
                text = Regex.Replace(text, " was slain.", "被杀死了。");

                //戴薇安锤子伤害
                text = Regex.Replace(text, " is to slow", "太慢了。");


                return NetworkText.FromLiteral(self.SourceCustomReason);
            }
            return orig(self, deadPlayerName);
        }

        private void BroadcastTranslate(On_ChatHelper.orig_BroadcastChatMessage orig, Terraria.Localization.NetworkText text, Color color, int excludedPlayer)
        {
            //多人模式广播文本

            //城镇戴薇安死亡
            if(text.ToString() == "Mutant has been enraged by the death of his sister!")
            {
                text = NetworkText.FromLiteral("突变体被他妹妹的死激怒了！");
            }

            //憎恶死亡
            if (text.ToString() == "Mutant has been enraged by the death of his brother!")
            {
                text = NetworkText.FromLiteral("突变体被他弟弟的死激怒了！");
            }

            //突变体死亡
            if (text.ToString() == "Mutant has been enraged!")
            {
                text = NetworkText.FromLiteral("突变体被激怒了！");
            }

            //城镇戴薇安被虫网抓住
            if (text.ToString() == "Mutant has been enraged by the abduction of his sister!")
            {
                text = NetworkText.FromLiteral("妹妹被绑架激怒了突变体！");
            }
            //肉山
            if(text.ToString() == "The Wall of Flesh is getting faster and stronger!") 
            {
                text = NetworkText.FromLiteral("血肉墙正在加速并变得更强大。");
            }

            //蜂后
            if(text.ToString() == "Queen Bee is getting weaker!")
            {
                text = NetworkText.FromLiteral("蜂后变得越来越弱！");
            }

            orig(text, color, excludedPlayer);
        }

        private int CombatTextTranslate(On_CombatText.orig_NewText_Rectangle_Color_string_bool_bool orig, Rectangle location, Color color, string text, bool dramatic, bool dot)
        {
            //悠悠球
            text = Regex.Replace(text, "Trolled", "溜了");

            //玩家被暴击
            if(text.StartsWith("CRIT! ") && text.EndsWith(" damage"))
            {
                text = Regex.Replace(text, "CRIT! ", "暴击! ");
                text = Regex.Replace(text, " damage", " 伤害");
            }
            return orig(location, color, text, dramatic, dot);
        }

        private List<TextSnippet> NewTextTranslate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //月亮领主心脏
            text = Regex.Replace(text, "Hehehehehehe! I GUARANTEE YOU DON'T HAVE ENOUGH POWER TO DEFEAT ME!!!", "哈哈哈哈哈哈！我保证你没有足够的力量打败我！！！");

            //克苏鲁真眼
            text = Regex.Replace(text, "Guys, Will you assist me for a moment?", "伙计们，能帮我一下吗？");
            text = Regex.Replace(text, "I'm going to bring more of my servants to assist me!", "我要召唤更多眼球来帮助我！");
            text = Regex.Replace(text, "Go servants, what are you all waiting for?", "去吧，眼球们，你们在等什么？");
            text = Regex.Replace(text, "Servants! Get this little peasant out of my sight at once!", "眼球们，让这个小野种马上滚出我的视线！");
            text = Regex.Replace(text, "Mwahahahahahahahahaha! Trap this tiny struggle at once!", "嘛哈哈哈哈哈哈哈哈哈，马上把这个小东西困住！");
            text = Regex.Replace(text, "Ahhhh, My eyes!", "啊啊啊啊，我的眼睛！");

            //月亮领主手
            text = Regex.Replace(text, "It looks like you can't defeat me!", "你败局已定！");
            text = Regex.Replace(text, "I see that you have annihilated my son!,You wimp!", "我看到你杀死了我的孩子！你这个闸总！");
            text = Regex.Replace(text, "I still have plenty of gimmicks and tricks left!", "我尚有诸多巧计与诡谲！");


            //月亮领主心脏受击
            text = Regex.Replace(text, "YOU THINK YOU CAN BUTCHER A GREAT LORD!?!", "你 觉 得 你 能 杀 死 伟 大 的 月 亮 之 主！？！");

            //月蛭凝块
            text = Regex.Replace(text, "WHAT ARE YOU DOING TO ME!?! Healing Leech Clots, Recover me at once!", "你在对我做什么！？！月蛭凝块，马上治疗我！");

            //月亮领主死亡
            text = Regex.Replace(text, "Ahhhhh! It was a mistake to cum here!", "哼哼哼啊啊啊啊啊啊，来这儿真他妈是个错误！");
            text = Regex.Replace(text, "The enemy souls are possessed by ethereal spirits...", "敌人的灵魂被幽灵附身……");

            //城镇憎恶死亡
            text = Regex.Replace(text, "Mutant has been enraged by the death of his brother!", "突变体被他弟弟的死激怒了！");

            //城镇戴薇安死亡
            text = Regex.Replace(text, "Mutant has been enraged by the death of his sister!", "突变体被他妹妹的死激怒了！");

            //城镇突变体死亡
            text = Regex.Replace(text, "Mutant has been enraged!", "突变体被激怒了！");

            //城镇戴薇安被虫网抓住
            text = Regex.Replace(text, "Mutant has been enraged by the abduction of his sister!", "妹妹被绑架激怒了突变体！");

            //与向导对话点制作会杀死向导，极限模式下还会生成一只地牢守卫
            text = Regex.Replace(text, "No cheating. Use recipe browser.", "别拆特，用Recipe Browser（配方浏览器）模组。");

            //花后石前在神庙内时
            text = Regex.Replace(text, "Something doesn't feel right about this place...", "这个地方有些不对劲……");
            text = Regex.Replace(text, "Your joints are slowly stiffening...", "你的关节正在慢慢变硬……");
            text = Regex.Replace(text, "What a strange sensation, it's like you're turning into...", "多么奇怪的感觉，就像你变成了……");
            text = Regex.Replace(text, "Looks like you have some time until the curse takes effect...", "看来在诅咒生效之前你还有一些时间……");
            text = Regex.Replace(text, "Your flesh feels rocky...", "你的血肉逐渐僵化……");

            //亚利姆的礼物
            text = Regex.Replace(text, "Ultra Hardcore is now active", "极限模式已开启。");
            text = Regex.Replace(text, "Ultra Hardcore deactivated, so bad.", "极限模式已关闭，真没劲。");

            //选择是否开启极限模式的UI
            text = Regex.Replace(text, "Enable Ultra Hardcore?", "是否开启极限模式？");
            text = Regex.Replace(text, "Yes, I like dying.", "是的，我想去死。");
            text = Regex.Replace(text, "No way!", "没门！");

            //戴薇安濒死
            text = Regex.Replace(text, "You got far. But you didn't pushed me to my limit", "你进步了。但你还没有让我发挥极限。");
            text = Regex.Replace(text, "Neither i did to you.", "我对你也没有。");
            text = Regex.Replace(text, "So terrarian. I will show you the power of my Love and determination.", "所以，泰拉人，我将向你展示我的爱和决心的力量。");

            //戴薇安锤子
            text = Regex.Replace(text, "KeepPressing Space to survive", "不想死就按住空格");

            //还是戴薇安
            text = Regex.Replace(text, "You pushed me to my limit.", "你让我发挥到了极限。");
            text = Regex.Replace(text, "You have earn my confidence.", "你赢得了我的信任。");
            text = Regex.Replace(text, "Good job Terrarian ❤️", "干得漂亮，泰拉人❤️");

            //肉山
            text = Regex.Replace(text, "The Wall of Flesh is getting faster and stronger!", "血肉墙正在加速并变得更强大。");

            //蜂后
            text = Regex.Replace(text, "Queen Bee is getting weaker!", "蜂后变得越来越弱！");

            return orig(text, baseColor);
        }

    }
}
