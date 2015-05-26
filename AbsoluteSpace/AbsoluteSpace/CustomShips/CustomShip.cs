using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AbsoluteSpace.CustomShips
{
    class CustomShip : FlxGroup
    {

        public CustomShip(int X, int Y, string BuildInfo)
        {


            FlxSprite body = new FlxSprite(X-4, Y-8);
            body.loadGraphic("as/ships_8x8", true, false, 16, 16);
            body.frame = FlxU.randomInt(3, 8);
            add(body);

            FlxSprite piece = new FlxSprite(X, Y);
            piece.loadGraphic("as/ships_8x8", true, false, 8, 8);
            piece.frame = FlxU.randomInt(0, 6);
            add(piece);


        }

        override public void update()
        {

            velocity.X = 4;
            velocity.Y = 7;

            angle = getAngleFromVelocity();

            base.update();

        }

        public override void kill()
        {

            base.kill();
        }
        public override void overlapped(FlxObject obj)
        {
            
            base.overlapped(obj);
        }

        public override void render(SpriteBatch spriteBatch)
        {

            base.render(spriteBatch);

        }


    }
}
