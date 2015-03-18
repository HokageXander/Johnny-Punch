using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Johnny_Punch
{
    abstract class GameObject
    {
        public Texture2D tex;
        public Vector2 pos;
        public Rectangle boundingBox;

        protected bool isDead;
        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }

        public GameObject(Texture2D tex, Vector2 pos, Rectangle boundingBox)
        {
            this.tex = tex;
            this.pos = pos;
            this.boundingBox = boundingBox;
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, pos, Color.White);
        }

    }
}
