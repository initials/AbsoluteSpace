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
    class PlayerShip : Ship
    {

        public PlayerShip(int xPos, int yPos)
            : base(xPos, yPos)
        {
            maxVelocity.X = 400;
            maxVelocity.Y = 400;
            setDrags(5000, 5000);
        }

        override public void update()
        {
            if (FlxG.keys.X)
            {
                shoot();
            }
            if (FlxControl.ACTIONJUSTPRESSED)
            {
                shoot();
            }

            move();

            

            base.update();

        }

        public void move()
        {

            float moveSpeed = 250;

            if (FlxControl.LEFT)
            {
                velocity.X -= moveSpeed;
            }

            if (FlxControl.RIGHT)
            {
                velocity.X += moveSpeed;
            }

            if (FlxControl.UP)
            {
                velocity.Y -= moveSpeed;
            }

            if (FlxControl.DOWN)
            {
                velocity.Y += moveSpeed;
            }

        }


    }
}
