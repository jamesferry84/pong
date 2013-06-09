using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace TutorialGame1
{
    class Ball
    {
        Texture2D texture;
        Vector2 position;
        float speed;
        Vector2 direction;
        Rectangle rect;

        public Rectangle Rect
        {
            get { return this.rect; }
            set { rect = value; }
        }

        public Vector2 Direction
        {
            get { return this.direction; }
            set { direction = value; }
        }

        public Vector2 Position
        {
            get { return this.position; }
            set { position = value; }
        }

        public Ball(ContentManager Content, string asset, Vector2 position)
        {
            texture = Content.Load<Texture2D>(asset);
            this.position = position;
            speed = 3f;
            direction = new Vector2(-1, -1);
        }

        public void Update(GameTime gameTime)
        {
            if (position.Y <= 0)
            {
                direction.Y *= -1;
            }
            if (position.Y + texture.Height >= 600)
            {
                direction.Y *= -1;
            }

                position += speed * direction;

            rect = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, Color.White);
        }
    }
}
