using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Johnny_Punch
{
    class GameManager
    {
        TextureManager textureManager;
        EnemyManager enemyManager;
        Player player;
        


        enum GameState
        {
            Start, Play, Pause, End
        }

        public void LoadContent(ContentManager Content, GraphicsDevice GraphicsDevice, SpriteBatch spriteBatch)
        {
            textureManager = new TextureManager(Content);
            enemyManager = new EnemyManager(GraphicsDevice);
            player = new Player(TextureManager.Player_tex, new Vector2(200, 200), new Rectangle(0, 0, 0, 0));
        }

        public void Update(GameTime gameTime)
        {
            enemyManager.Update(gameTime);
            player.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            enemyManager.Draw(spriteBatch);
            player.Draw(spriteBatch);


        }

        public static void CheckIsDead()
        {

        }
    }
}
