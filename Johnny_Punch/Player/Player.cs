using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Johnny_Punch
{
    class Player : GameObject
    {
        public int lifePoints;
        public Vector2 speed;
        public Rectangle sourceRect;
        public KeyboardState keyBoardState;
        public KeyboardState oldKeyBoardState;
        
        public Player(Texture2D tex, Vector2 pos, Rectangle boundingBox)
            : base(tex,pos,boundingBox)
        {
            //this.tex = tex;
            this.pos = pos;
            this.boundingBox =  sourceRect;
            sourceRect = new Rectangle(0, 0, 96, 136);
            this.speed = new Vector2(0, 0);
        }

        public virtual void Update(GameTime gameTime)
        {
            oldKeyBoardState = keyBoardState;
            keyBoardState = Keyboard.GetState();
            pos += speed;
            speed.X = 0;
            speed.Y = 0;

            if(keyBoardState.IsKeyDown(Keys.Right))
            {
                speed.X = 3;
            }
            if (keyBoardState.IsKeyDown(Keys.Left))
            {
                speed.X = -3;
                
            }
            if (keyBoardState.IsKeyDown(Keys.Up))
            {
                speed.Y = -3;
            }
            if (keyBoardState.IsKeyDown(Keys.Down))
            {
                speed.Y = 3;
            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if(keyBoardState.IsKeyDown(Keys.Left))
            {
                spriteBatch.Draw(tex, pos, sourceRect, Color.White, 0f, new Vector2(sourceRect.Width / 2, sourceRect.Height / 2), 1f, SpriteEffects.FlipHorizontally, 0f);

            }
            else
                spriteBatch.Draw(tex, pos, sourceRect, Color.White, 0f, new Vector2(sourceRect.Width / 2, sourceRect.Height / 2), 1f, SpriteEffects.None, 0f);

            //spriteBatch.Draw(tex, pos, sourceRect, Color.Red);
        }
        
        
        //public Vector2 GetPos
        //{
        //    get
        //    {
        //        return pos;
        //    }
        //}

        //public Rectangle GetRec
        //{
        //    get
        //    {
        //        return hitBox;
        //    }
        //}
        
    }
}
