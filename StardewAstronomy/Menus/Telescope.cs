using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using StardewValley.BellsAndWhistles;
using StardewValley;
using StardewValley.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewAstronomy.Menus
{
    public class Telescope : IClickableMenu
    {
        public Texture2D texture;
        public Telescope()
        : base((int)Utility.getTopLeftPositionForCenteringOnScreen(1280, 720).X, (int)Utility.getTopLeftPositionForCenteringOnScreen(1280, 720).Y, 1280, 720, showUpperRightCloseButton: true)
        {
            Game1.playSound("shwip");
            //this.backButton = new ClickableTextureComponent(new Rectangle(base.xPositionOnScreen + 32, base.yPositionOnScreen + base.height - 32 - 64, 48, 44), Game1.mouseCursors, new Rectangle(352, 495, 12, 11), 4f)
            //{
            //    myID = 101,
            //    rightNeighborID = 102
            //};
            //this.forwardButton = new ClickableTextureComponent(new Rectangle(base.xPositionOnScreen + base.width - 32 - 48, base.yPositionOnScreen + base.height - 32 - 64, 48, 44), Game1.mouseCursors, new Rectangle(365, 495, 12, 11), 4f)
            //{
            //    myID = 102,
            //    leftNeighborID = 101
            //};
            this.texture = Game1.temporaryContent.Load<Texture2D>("LooseSprites\\letterBG");
            //text = this.ApplyCustomFormatting(text);
            //this.mailMessage = SpriteText.getStringBrokenIntoSectionsOfHeight(text, base.width - 64, base.height - 128);
            //this.forwardButton.visible = this.page < this.mailMessage.Count - 1;
            //this.backButton.visible = this.page > 0;
            //this.OnPageChange();
            base.populateClickableComponentList();
            if (Game1.options.SnappyMenus)
            {
                this.snapToDefaultClickableComponent();
            }
        }

        public override void draw(SpriteBatch b)
        {
            // Fade out surrounding view
            b.Draw(
                Game1.fadeToBlackRect,
                Game1.graphics.GraphicsDevice.Viewport.Bounds,
                Color.Black * 0.4f
            );
            // Draw background
            b.Draw(
                this.texture,
                new Vector2(base.xPositionOnScreen + base.width / 2, base.yPositionOnScreen + base.height / 2),
                new Rectangle(0, 0, 320, 180),
                Color.White,
                0f,
                new Vector2(160f, 90f),
                4f,
                SpriteEffects.None,
                0.86f
            );
            // Draw a night sky
            b.Draw(
                Game1.fadeToBlackRect,
                new Vector2(base.xPositionOnScreen + base.width / 2, base.yPositionOnScreen + base.height / 2),
                new Rectangle(0, 0, 100, 100),
                Color.Black,
                0f,
                new Vector2(100f, 50f),
                4f,
                SpriteEffects.None,
                0.85f
            );
            Point[] stars =
            {
                new Point(0, 0),
            };
            // Get current time
            int time = Game1.timeOfDay / 100;
            // Each star begins at a point and moves left based on the time of day
            for ( int i = 0; i < stars.Length; i++ )
            {
                b.Draw(
                    Game1.fadeToBlackRect,
                    new Vector2(base.xPositionOnScreen + base.width / 2, base.yPositionOnScreen + base.height / 2),
                new Rectangle(0, 0, 1, 1),
                Color.White,
                0f,
                new Vector2(stars[i].X + time, stars[i].Y),
                4f,
                SpriteEffects.None,
                0.85f
                    );
            }
            
        }
    }
}
