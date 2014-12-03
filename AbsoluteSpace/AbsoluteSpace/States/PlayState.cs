using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

using AbsoluteSpace.Ships;

namespace AbsoluteSpace.States
{
    public class PlayState : FlxState
    {

        override public void create()
        {
            base.create();

            for (int i = 0; i < 10; i++)
            {
                Ship ship = new Ship(FlxU.randomInt(0, FlxG.width), FlxU.randomInt(0, FlxG.height));
                add(ship);
                if (i != 0) ship.play("transform");
            }

        }

        override public void update()
        {




            base.update();
        }


    }
}
