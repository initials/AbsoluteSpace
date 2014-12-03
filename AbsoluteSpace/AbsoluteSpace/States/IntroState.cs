using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

namespace AbsoluteSpace.States
{
    public class IntroState : FlxState
    {
        private FlxText introductionText;

        override public void create()
        {
            FlxG.backColor = Color.Purple;

            base.create();

            introductionText = new FlxText(0, 30, FlxG.width);
            introductionText.setFormat("flixel/initials/SpaceMarine", 1, Color.LightBlue, Color.Black, FlxJustification.Center);
            introductionText.text = "Welcome to Absolute Space\nPress SPACEBAR";
            add(introductionText);




        }

        override public void update()
        {

            if (FlxG.keys.SPACE && elapsedInState > 0.5f)
            {
                FlxG.state = new AbsoluteSpace.States.PlayState();
                return;
            }


            base.update();
        }


    }
}
