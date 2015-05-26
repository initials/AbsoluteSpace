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
    class Bullet : FlxSprite
    {

        public Bullet(int xPos, int yPos)
            : base(xPos, yPos)
        {
            createGraphic(4,4, Color.AliceBlue);
            setDrags(0, 0);

            maxVelocity.X = 10000;
            maxVelocity.Y = 10000;
        }

        override public void update()
        {

            if (y < -10)
            {
                dead = true;
                x = originalPosition.X;
                y = originalPosition.Y;
                velocity = Vector2.Zero;

            }

            base.update();

        }


    }
}
