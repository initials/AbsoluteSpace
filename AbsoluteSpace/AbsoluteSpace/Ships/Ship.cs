using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AbsoluteSpace.Ships
{
    class Ship : FlxSprite
    {

        public Ship(int xPos, int yPos)
            : base(xPos, yPos)
        {
            loadGraphic("flixel/surt/spaceship_32x32", true, false, 32, 32);

            //Add some animations to our Spaceship
            addAnimation("static", new int[] { 0 }, 36, true);
            addAnimation("transform1", new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 12, false);
            addAnimation("transform2", new int[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 }, 12, false);
            addAnimation("transform3", new int[] { 40, 41, 42 }, 12, false);
            addAnimation("transform", this.generateFrameNumbersBetween(0, 39), 24, false);
            addAnimation("reverse", this.generateFrameNumbersBetween(39, 0), 24, false);
            play("static");
        }

        override public void update()
        {


            base.update();

        }


    }
}
