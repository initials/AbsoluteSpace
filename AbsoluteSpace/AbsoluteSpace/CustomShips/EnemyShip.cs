using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using AbsoluteSpace.Ships;

namespace AbsoluteSpace.CustomShips
{
    class EnemyShip : Ship
    {

        public EnemyShip(int xPos, int yPos)
            : base(xPos, yPos)
        {
            loadGraphic(FlxG.Content.Load<Texture2D>("as/ships_64x64"), true, false, 64, 64);

            frame = FlxU.randomInt(0, 10);

            velocity.Y = FlxU.randomInt(22, 44);
            angle = 180;


        }

        override public void update()
        {


            if (overlapsPoint(FlxG.mouse.x, FlxG.mouse.y))
            {
                if (FlxG.mouse.justPressed() && color==Color.Red)
                    y = -64;

            }

            if (y > FlxG.height)
            {
                color = Color.White;
                y = -64;
            }

            base.update();

        }

        public override void kill()
        {
            foreach (var item in bullets.members)
            {
                item.dead = false;
                item.x = x;
                item.y = y;
                item.velocity.X = FlxU.randomInt(-100, 100);
                item.velocity.Y = FlxU.randomInt(-100, 100);

            }
            base.kill();
        }

        public override void overlapped(FlxObject obj)
        {
            
            base.overlapped(obj);
        }


    }
}
