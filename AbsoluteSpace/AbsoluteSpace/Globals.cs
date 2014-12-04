using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace AbsoluteSpace
{
    public class Globals
    {
        public static int totalDistance = 0;

        /// <summary>
        /// Action global that includes the mouse.
        /// </summary>
        public static bool ACTION
        {
            get
            {
                return FlxG.keys.N ||
                    FlxG.keys.X ||
                    FlxG.keys.ENTER ||
                    FlxG.keys.SPACE ||
                    FlxG.gamepads.isButtonDown(Buttons.A) ||
                    FlxG.gamepads.isButtonDown(Buttons.Start) || 
                    FlxG.mouse.pressed();
            }
        }

        public static bool ACTIONJUSTPRESSED
        {
            get
            {
                return  
                    FlxG.keys.justPressed(Keys.N) ||
                    FlxG.keys.justPressed(Keys.X) ||
                    FlxG.keys.justPressed(Keys.Enter) ||
                    FlxG.keys.justPressed(Keys.Space) ||
                    FlxG.gamepads.isNewButtonPress(Buttons.A) ||
                    FlxG.gamepads.isNewButtonPress(Buttons.Start) ||
                    (FlxG.mouse.justPressed() );
            }
        }

    }
}
