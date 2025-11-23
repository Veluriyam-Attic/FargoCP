#pragma warning disable CA2255
using FargoCP.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace FargoCP.FargosSoulsModDLCRecreatedTranslator
{
	public class FargosSoulsModDLCRecreatedTranslator
	{
		private class FargosSoulsModDLCRecreated{}
		[ExtendsFromMod("FargosSoulsModDLCRecreated"), JITWhenModsEnabled("FargosSoulsModDLCRecreated")]
		private class TranslatorLoad : ForceLocalizeSystem<FargosSoulsModDLCRecreated, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("FargosSoulsModDLCRecreated",out _))
			{
				#region FargosSoulsModDLCRecreated.Items.Calamity.Souls.CalamitySoul
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Souls.CalamitySoul", "SafeModifyTooltips", new ()
				{
					{"获得天蓝、斯塔提和渊泉的套装奖励","All armor bonuses from Aerospec, Statigel, and Hydrothermic"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Souls.CalamitySoul


				#region FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.SpiritTrapperEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.SpiritTrapperEnchant+<>c", "<AddRecipes>b__11_0", new ()
				{
					{"猎魂头盔"," Spirit Trapper Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.SpiritTrapperEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant+<>c", "<AddRecipes>b__6_0", new ()
				{
					{"弄臣面具"," Jester Mask"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant+<>c", "<AddRecipes>b__6_1", new ()
				{
					{"弄臣服"," Jester Shirt"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant+<>c", "<AddRecipes>b__6_2", new ()
				{
					{"弄臣裤"," Jester Leggings"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant+<>c", "<AddRecipes>b__6_3", new ()
				{
					{"粉丝的信函"," Letter"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant+<>c", "<AddRecipes>b__6_4", new ()
				{
					{"邪恶木铃鼓"," Tambourine"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.JesterEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.CrierEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.CrierEnchant+<>c", "<AddRecipes>b__5_0", new ()
				{
					{"军号"," Bugle Horn"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.CrierEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.TitanEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.TitanEnchant+<>c", "<AddRecipes>b__6_0", new ()
				{
					{"泰坦头盔"," Titan Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.TitanEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.AssassinEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.AssassinEnchant+<>c", "<AddRecipes>b__6_0", new ()
				{
					{"刺客头盔"," Assassin Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Thorium.Enchantments.AssassinEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.SilvaEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.SilvaEnchant+<>c", "<AddRecipes>b__13_0", new ()
				{
					{"始源林海头盔"," Silva Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.SilvaEnchant+<>c", "<AddRecipes>b__13_1", new ()
				{
					{"始源林海"," Silva Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.SilvaEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.ReaverEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.ReaverEnchant+<>c", "<AddRecipes>b__10_0", new ()
				{
					{"掠夺者头盔"," Reaver Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.ReaverEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VoidFaquirEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VoidFaquirEnchant+<>c", "<AddRecipes>b__5_0", new ()
				{
					{"虚空行者头盔"," Void Faquir Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VoidFaquirEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.DaedalusEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.DaedalusEnchant+<>c", "<AddRecipes>b__11_0", new ()
				{
					{"代达罗斯头盔"," Daedalus Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.DaedalusEnchant+<>c", "<AddRecipes>b__11_1", new ()
				{
					{"代达罗斯头盔"," Daedalus Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.DaedalusEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.TarragonEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.TarragonEnchant+<>c", "<AddRecipes>b__7_0", new ()
				{
					{"龙蒿头盔"," Tarragon Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.TarragonEnchant+<>c", "<AddRecipes>b__7_1", new ()
				{
					{"龙蒿头盔"," Tarragon Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.TarragonEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AuricEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AuricEnchant+<>c", "<AddRecipes>b__9_0", new ()
				{
					{"古圣金源头盔"," Auric Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AuricEnchant+<>c", "<AddRecipes>b__9_1", new ()
				{
					{"古圣金源头盔"," Auric Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AuricEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.BloodflareEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.BloodflareEnchant+<>c", "<AddRecipes>b__11_0", new ()
				{
					{"血炎头盔"," Bloodflare Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.BloodflareEnchant+<>c", "<AddRecipes>b__11_1", new ()
				{
					{"血炎头盔"," Bloodflare Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.BloodflareEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VictideEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VictideEnchant+<>c", "<AddRecipes>b__7_0", new ()
				{
					{"胜潮头盔"," Victide Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VictideEnchant+<>c", "<AddRecipes>b__7_1", new ()
				{
					{"胜潮头盔"," Victide Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.VictideEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.StatigelEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.StatigelEnchant+<>c", "<AddRecipes>b__8_0", new ()
				{
					{"斯塔提斯头盔"," Statigel Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.StatigelEnchant+<>c", "<AddRecipes>b__8_1", new ()
				{
					{"斯塔提斯头盔"," Statigel Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.StatigelEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AtaxiaEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AtaxiaEnchant+<>c", "<AddRecipes>b__11_0", new ()
				{
					{"渊泉头盔"," Hydrothermic Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AtaxiaEnchant+<>c", "<AddRecipes>b__11_1", new ()
				{
					{"渊泉头盔"," Hydrothermic Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AtaxiaEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.GodSlayerEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.GodSlayerEnchant+<>c", "<AddRecipes>b__9_0", new ()
				{
					{"弑神者头盔"," Godslayer Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.GodSlayerEnchant+<>c", "<AddRecipes>b__9_1", new ()
				{
					{"弑神者头盔"," Godslayer Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.GodSlayerEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.IntergelacticEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.IntergelacticEnchant+<>c", "<AddRecipes>b__6_0", new ()
				{
					{"异宇星凝头盔"," Intergelactic Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.IntergelacticEnchant/<>c


				#region FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AerospecEnchant/<>c
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AerospecEnchant+<>c", "<AddRecipes>b__8_0", new ()
				{
					{"天蓝头盔"," Aerospec Helmet"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AerospecEnchant+<>c", "<AddRecipes>b__8_1", new ()
				{
					{"天蓝头盔"," Aerospec Helmet"},
				});
				#endregion FargosSoulsModDLCRecreated.Items.Calamity.Enchantments.AerospecEnchant/<>c


			}
		}
	}
}
