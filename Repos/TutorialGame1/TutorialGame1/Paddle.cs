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
    class Paddle
    {
        Texture2D texture;
        Vector2 position;
        float speed;
        Rectangle rect;
        bool isPlayer;

        KeyboardState keyState;

        public Rectangle Rect
        {
            get { return this.rect; }
            set { rect = value; }
        }

        public Paddle(ContentManager Content, string asset, Vector2 position, bool isPlayer)
        {
            texture = Content.Load<Texture2D>(asset);
            this.position = position;
            speed = 10f;
            this.isPlayer = isPlayer;
        }


        public void Update(GameTime gametime, Ball ball)
        {
            keyState = Keyboard.GetState();

            if (isPlayer)
            {
                if (keyState.IsKeyDown(Keys.Down) && (position.Y <= 600 - texture.Height))
                {
                    position.Y += speed;
                }
                if (keyState.IsKeyDown(Keys.Up) && position.Y > 0)
                {
                    position.Y -= speed;
                }
            }
            else
            {
                if (ball.Position.Y >= position.Y)
                {
                    position.Y += speed;
                }
                if (ball.Position.Y <= position.Y)
                {
                    position.Y -= speed;
                }
            }

            rect = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, Color.White);
        }
    }
}
