using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

using AbsoluteSpace.Environment;

using AbsoluteSpace.Ships;
using AbsoluteSpace.CustomShips;

namespace AbsoluteSpace.States
{
    public class PlayState : FlxState
    {
        private PlayerShip player;
        private EnemyShip enemy;
        private FlxGroup enemies;
        private Starfield starField;
       

        override public void create()
        {
            base.create();

            //FlxG.mouse.show();

            starField = new Starfield();
            add(starField);

            //player = new PlayerShip(FlxU.randomInt(0, FlxG.width/2), FlxU.randomInt(0, FlxG.height));
            player = new PlayerShip(FlxG.width / 2, FlxG.height-40);

            add(player);

            enemies = new FlxGroup();

            for (int i = 0; i < 10; i++)
            {
                enemy = new EnemyShip(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, 30));
                enemies.add(enemy);
            }

            add(enemies);

        }

        override public void update()
        {

            FlxU.overlap(enemies, player.bullets, overlapped);

            if (enemies.getFirstAlive() == null)
            {
                starField.setSpeed(100, 400);
            }

            

            base.update();

            
        }


        protected bool overlapped(object Sender, FlxSpriteCollisionEvent e)
        {
            //FlxG.quake.start(0.015f, 1);

            starField.blastStarsAtRegion(e.Object1.x + e.Object1.width/2, e.Object1.y + e.Object1.height/2);

            e.Object1.kill();
            //e.Object2.kill();

            ((FlxObject)(e.Object1)).overlapped(e.Object2);
            ((FlxObject)(e.Object2)).overlapped(e.Object1);
            return true;
        }


    }
}
