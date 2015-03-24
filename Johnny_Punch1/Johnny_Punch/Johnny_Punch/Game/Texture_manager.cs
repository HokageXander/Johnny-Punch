using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Johnny_Punch
{
    public static class TextureManager
    {
        public static Texture2D backgroundTex { get; private set; }
        public static Texture2D Player_tex { get; private set; }
        public static SpriteFont Status_font { get; private set; }
        public static Texture2D Tiny_tim { get; private set; }


        public static void LoadContent(ContentManager Content)
        {
            backgroundTex = Content.Load<Texture2D>(@"Images\background");
            Player_tex = Content.Load<Texture2D>(@"Images\DragonDude");
            Tiny_tim = Content.Load<Texture2D>(@"Images\tinytim");
            //Status_font = content.Load<SpriteFont>("BlaBla");
        }
    }
}
