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
        public FlxGroup bullets;

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

            if (FlxG.debug) debugName = "mouseControl";

            bullets = new FlxGroup();
            for (int i = 0; i < 35; i++)
            {
                Vector2 place = new Vector2(-100, -100);
                Console.WriteLine(this.GetType().ToString());
                if (this.GetType().ToString() == "AbsoluteSpace.Ships.PlayerShip")
                    place = new Vector2(10 + (i * 5), 10);
                Bullet b = new Bullet((int)place.X,(int)place.Y);
                b.dead = true;
                b.debugName = i.ToString();
                bullets.add(b);
            }
            
        }

        override public void update()
        {
            if (debugName == "mouseControl")
            {
                angle = (FlxU.getAngle(new Vector2(this.x, this.y), new Vector2(FlxG.mouse.x, FlxG.mouse.y))) + 90;
                setVelocityFromAngle(150);
                angle -= 90;
            }

            bullets.update();
            base.update();

        }

        public override void render(SpriteBatch spriteBatch)
        {
            foreach(Bullet b in bullets.members) 
            {
                b.render(spriteBatch);
            }

            base.render(spriteBatch);
        }

        public void shoot()
        {
            
            FlxObject b = bullets.getFirstDead();
            //Console.WriteLine("shoot " + b.debugName);
            if (b != null)
            {
                b.dead = false;
                b.x = this.x + this.width / 2;
                b.y = this.y - 5;
                b.velocity.Y = -250;
                
            }
            else
            {
                Console.WriteLine("Could not fire");

            }
        }


    }
}
