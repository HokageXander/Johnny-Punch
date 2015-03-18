using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Johnny_Punch
{
    class TextureManager
    {
        public static Texture2D Player_tex;
        public static SpriteFont Status_font;
        public static Texture2D Tiny_tim;


        public TextureManager(ContentManager content)
        {
            Player_tex = content.Load<Texture2D>("DragonDude");
            Tiny_tim = content.Load<Texture2D>("tinytim");
            //Status_font = content.Load<SpriteFont>("BlaBla");
        }
    }
}
