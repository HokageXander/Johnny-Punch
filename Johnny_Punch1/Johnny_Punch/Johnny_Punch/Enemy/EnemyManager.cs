using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Johnny_Punch
{
    class EnemyManager
    {

        public static List<Enemy> enemyList = new List<Enemy>();


        public EnemyManager(GraphicsDevice graphicsDevice)
        {
            EnemyType();

        }

        public void Update(GameTime gameTime)
        {

                
            
            

            foreach (Enemy enemy in enemyList)
            {
                enemy.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Enemy enemy in enemyList)
            {
                enemy.Draw(spriteBatch);

            }
            
        }

        public void EnemyType()
        {
            //enemyList.Add(new Little_tim(TextureManager.Tiny_tim, new Vector2(500, 400), new Rectangle(0, 0, 0, 0)));
        }

        public void SpawnEnemy(GameTime gameTime)
        {

        }
        
    }
}
