using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
namespace GameStateManagement
{
    public class PlayerCharacter : Character
    {
        private const float MOVEMENT_SPEED = 160f; // move speed px pr. sec.

        public PlayerCharacter(GameRenderManager renMan, ContentManager content, Point pos)
            : base(pos, renMan, content)
        {
        }

        public override void LoadContent()
        {

        }

        public override void Update(float deltaTime)
        {
            KeyboardState keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.W))
            {
                position.Y -= deltaTime * MOVEMENT_SPEED;
            }
            else if (keyState.IsKeyDown(Keys.D))
            {
                position.X += deltaTime * MOVEMENT_SPEED;
            }
            else if (keyState.IsKeyDown(Keys.S))
            {
                position.Y += deltaTime * MOVEMENT_SPEED;
            }
            else if (keyState.IsKeyDown(Keys.A))
            {
                position.X -= deltaTime * MOVEMENT_SPEED;
            }

            //Update();
        }
    }
}
