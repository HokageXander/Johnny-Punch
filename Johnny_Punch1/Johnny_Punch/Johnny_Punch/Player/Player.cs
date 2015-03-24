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
        //public int lifePoints;
        public Vector2 speed;
        public Rectangle animation, feetBox;
        public KeyboardState keyBoardState, oldKeyBoardState;
        int yLimitUp = 335, yLimitDown = 583;
        
        public Player(Texture2D tex, Vector2 pos, Rectangle boundingBox)
            : base(tex,pos,boundingBox)
        {
            //this.tex = tex;
            this.pos = pos;
            this.boundingBox = boundingBox;
            //this.boundingBox =  sourceRect;
            animation = new Rectangle(0, 0, 92, 119);
            width /= 3;
            
            this.speed = new Vector2(0, 0);
        }

        public virtual void Update(GameTime gameTime)
        {
            oldKeyBoardState = keyBoardState;
            keyBoardState = Keyboard.GetState();
            pos += speed;
            speed.X = 0;
            speed.Y = 0;

            boundingBox = new Rectangle((int)pos.X - width/2, (int)pos.Y - height/2, width, height);
            feetBox = new Rectangle((int)pos.X - width/2, (int)pos.Y + (height - 4) - height/2, width, height - (height - 4));

            if (keyBoardState.IsKeyDown(Keys.Right) || keyBoardState.IsKeyDown(Keys.D))
            {
                speed.X = 3;
            }
            if (keyBoardState.IsKeyDown(Keys.Left) || keyBoardState.IsKeyDown(Keys.A))
            {
                speed.X = -3;
                
            }
            if (keyBoardState.IsKeyDown(Keys.Up) || keyBoardState.IsKeyDown(Keys.W) && feetBox.Y >= yLimitUp)
            {
                speed.Y = -3;
            }
            if (keyBoardState.IsKeyDown(Keys.Down) || keyBoardState.IsKeyDown(Keys.S) && feetBox.Y <= yLimitDown)
            {
                speed.Y = 3;
            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (keyBoardState.IsKeyDown(Keys.Left) || keyBoardState.IsKeyDown(Keys.A))
            {
                spriteBatch.Draw(tex, pos, animation, Color.White, 0f, new Vector2(boundingBox.Width / 2, boundingBox.Height / 2), 1f, SpriteEffects.FlipHorizontally, 0f);

            }
            else
                spriteBatch.Draw(tex, pos, animation, Color.White, 0f, new Vector2(boundingBox.Width / 2, boundingBox.Height / 2), 1f, SpriteEffects.None, 0f);

            spriteBatch.Draw(tex, feetBox, Color.Red);
            //spriteBatch.Draw(tex, boundingBox, Color.Red);
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
