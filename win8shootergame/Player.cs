﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics; 

namespace Shooter
{
    class Player
    {
        public Texture2D PlayerTexture;
        public Vector2 Position;
        public bool Active;
        public int Health;
        
        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        public int Height
        {
            get { return PlayerTexture.Height; }
        }

        public void Initialize(Texture2D texture, Vector2 position)
        {

            PlayerTexture = texture;



            // Set the starting position of the player around the middle of the screen and to the back

            Position = position;



            // Set the player to be active

            Active = true;



            // Set the player health

            Health = 100;

        }


        public void Update()
        {
        
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f,

               SpriteEffects.None, 0f);

        }

    }
}
