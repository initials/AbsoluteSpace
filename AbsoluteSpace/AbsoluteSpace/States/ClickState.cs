using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

using AbsoluteSpace.Ships;
using AbsoluteSpace.CustomShips;

namespace AbsoluteSpace.States
{
    public class ClickState : FlxState
    {

        private EnemyShip enemy;
        private FlxGroup enemies;
        private int elapsed;

        override public void create()
        {
            base.create();

            FlxG.mouse.show();

            enemies = new FlxGroup();

            for (int i = 0; i < 10; i++)
            {
                enemy = new EnemyShip(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, FlxG.height));
                enemies.add(enemy);
            }

            add(enemies);

        }

        override public void update()
        {

            if (elapsed % 64 == 1)
            {
                EnemyShip x = (EnemyShip) enemies.getRandom();
                x.color = Color.Red;

            }


            base.update();

            elapsed++;
        }


        protected bool overlapped(object Sender, FlxSpriteCollisionEvent e)
        {
            e.Object1.kill();

            ((FlxObject)(e.Object1)).overlapped(e.Object2);
            ((FlxObject)(e.Object2)).overlapped(e.Object1);
            return true;
        }


    }
}
