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
    class Starfield : FlxGroup
    {

        public Starfield()
            : base()
        {
            for (int i = 0; i < 500; i++)
            {
                Star star = new Star(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, FlxG.height));
                add(star);
            }

            setSpeed(10, 20);

            
        }

        override public void update()
        {


            base.update();

        }

        public override void render(SpriteBatch spriteBatch)
        {

            base.render(spriteBatch);
        }

        public void setSpeed(float MinSpeed, float MaxSpeed)
        {
            foreach (Star item in members)
            {
                item.velocity.Y = FlxU.random(MinSpeed, MaxSpeed);
            }
        }

        public void blastStarsAtRegion(float X, float Y)
        {
            foreach (Star item in members)
            {
                float dist = FlxU.getDistance(new Vector2(X,Y), new Vector2(item.x,item.y));
                //Console.WriteLine(dist);
                if (dist<40)
                {
                    item.shudderTimer = 0;

                    //item.velocity.X = FlxU.randomInt(-100, 100);
                    //item.velocity.Y = FlxU.randomInt(-100, 100);

                }
            }
        }

    }
}
