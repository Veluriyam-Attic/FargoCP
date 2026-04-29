using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace FargoCP.Common
{
    //来自Fargo魂源码通知
    public class EnterWorldNotification:IInGameNotification
    {
        public bool ShouldBeRemoved => Timer <= 0;

        private int Timer = 60 * 5;

        private Asset<Texture2D> iconTexture = ModContent.Request<Texture2D>("FargoCP/icon_small");

        //UI缩放尺寸
        private float Scale
        {
            get
            {
                if (Timer < 30)
                {
                    return MathHelper.Lerp(0f, 1f, Timer / 30f);
                }

                if (Timer > 285)
                {
                    return MathHelper.Lerp(1f, 0f, (Timer - 285) / 15f);
                }

                return 1f;
            }
        }

        //不透明度
        private float Opacity
        {
            get
            {
                if (Scale <= 0.5f)
                {
                    return 0f;
                }

                return (Scale - 0.5f) / 0.5f;
            }
        }

        //光标悬停UI
        private void OnMouseOver()
        {
            //判断是否处于忽略光标情况
            if (PlayerInput.IgnoreMouseInterface)
            {
                return;
            }

            Main.LocalPlayer.mouseInterface = true;

            if (!Main.mouseLeft || !Main.mouseLeftRelease)
            {
                return;
            }

            Main.mouseLeftRelease = false;

            if (Timer > 30 && Timer < 255)
            {
                Timer = 30;
            }
        }

        public void Update() 
        {
            //计时器减少
            if (Timer <= 30 ||Timer >=200) 
            {
                Timer--;
            }

            if (Timer < 0) 
            {
                Timer = 0;
            }
        }

        public void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition) 
        {
            if (Opacity <= 0f)
            {
                return;
            }

            //先绘制面板，再绘制图标和文本
            string title = Language.GetTextValue("Mods.FargoCP.OnEnterWorldText", "《Fargo附属汉化合集》");

            float effectiveScale = Scale * 1.1f;
            Vector2 size = (FontAssets.ItemStack.Value.MeasureString(title) + new Vector2(58f, 100f)) * effectiveScale;
            Rectangle panelSize = Utils.CenteredRectangle(bottomAnchorPosition + new Vector2(0f, (0f - size.Y) * 0.5f), size);

            //检查光标在对话框上
            bool hovering = panelSize.Contains(Main.MouseScreen.ToPoint());

            Utils.DrawInvBG(spriteBatch, panelSize, new Color(64, 109, 164) * (hovering ? 0.75f : 0.5f));
            float iconScale = effectiveScale * 0.7f;

            Vector2 vector = panelSize.Right() - Vector2.UnitX * effectiveScale * (12f + iconScale * iconTexture.Width());

            spriteBatch.Draw(iconTexture.Value, vector, null, Color.White * Opacity, 0f, new Vector2(0f, iconTexture.Width() / 2f), iconScale, SpriteEffects.None, 0f);
            
            Utils.DrawBorderString(
                color: new Color(Main.mouseTextColor, Main.mouseTextColor, Main.mouseTextColor / 5, Main.mouseTextColor) * Opacity,
                sb: spriteBatch, 
                text: title, 
                pos: vector - Vector2.UnitX * 10f, 
                scale: effectiveScale * 0.9f, 
                anchorx: 1f, 
                anchory: 0.4f);

            if (hovering)
            {
                OnMouseOver();
            }
        }

        public void PushAnchor(ref Vector2 positionAnchorBottom) 
        {
            positionAnchorBottom.Y -= 180f * Opacity;
        }
    }
}
