using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AbsoluteSpace.Environment
{
    class Star : FlxSprite
    {
        public float shudderTimer;

        public Star(int xPos, int yPos)
            : base(xPos, yPos)
        {
            createGraphic(FlxU.randomInt(0, 3), FlxU.randomInt(0, 3), Color.WhiteSmoke);

            x = xPos;
            y = yPos;

            //velocity.Y = FlxU.random(50, 200);

            if (velocity.Y>180)
                _color = new Color(255, (float)(-180 + (velocity.Y)), (float)(-180 + (velocity.Y)));

            shudderTimer = float.MaxValue;
        }

        override public void update()
        {
            shudderTimer += FlxG.elapsed;

            if (y > FlxG.height)
            {
                rebirth();
            }

            if (shudderTimer < 2.0f)
            {
                x += FlxU.randomInt(-5, 5);

                //scale = 3;
            }
            else
            {
                //scale = 1;
            }

            base.update();

        }

        public void rebirth()
        {
            x = FlxU.randomInt(0, FlxG.width);

            y = -10;
 
        }


    }
}
