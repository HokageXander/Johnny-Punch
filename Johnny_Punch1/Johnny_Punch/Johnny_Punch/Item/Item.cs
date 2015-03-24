using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Johnny_Punch
{
    class Item : GameObject
    {
        public Item(Texture2D tex, Vector2 pos, Rectangle bounding_box)
            :base(tex,pos,bounding_box)
        {

        }
    }
}
