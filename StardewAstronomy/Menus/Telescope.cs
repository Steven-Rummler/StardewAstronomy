using Microsoft.Xna.Framework.Graphics;
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
            //this.letterTexture = Game1.temporaryContent.Load<Texture2D>("LooseSprites\\letterBG");
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
    }
}
