using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Johnny_Punch
{
    abstract class Enemy : GameObject
    {
        public Rectangle sourceRect;
        protected double frameTimer = 100;
        protected double frameInterval = 100;
        protected int frame;
        public float speed;
        public float life;

        public Enemy(Texture2D tex, Vector2 pos, Rectangle bounding_box)
            : base(tex,pos,bounding_box)
        {
            this.boundingBox = sourceRect;
            sourceRect = new Rectangle(0, 0, 360, 450);
            
        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, pos, sourceRect, Color.White, 0f, new Vector2(sourceRect.Width / 2, sourceRect.Height / 2), 1f, SpriteEffects.None,0f);
            //spriteBatch.Draw(tex, pos, sourceRect, Color.Red);
        }
    }
}
