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
    public class PlayState : FlxState
    {
        private Ship player;
        private CustomShip enemy;
        private FlxGroup enemies;


        override public void create()
        {
            base.create();

            FlxG.mouse.show();

            player = new Ship(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, FlxG.height));
            add(player);

            enemies = new FlxGroup();

            for (int i = 0; i < 10; i++)
            {
                enemy = new CustomShip(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, FlxG.height), "11111111111");
                enemies.add(enemy);
            }

            add(enemies);

        }

        override public void update()
        {

            FlxU.overlap(enemies, player, overlapped);


            base.update();
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
