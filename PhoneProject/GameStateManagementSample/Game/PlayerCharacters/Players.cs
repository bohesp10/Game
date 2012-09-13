using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameStateManagement
{
    /// <summary>
    /// Blue square
    /// </summary>
    public class BlueCharacter : PlayerCharacter
    {

        public BlueCharacter(GameRenderManager renMan, ContentManager content, Point pos)
            : base(renMan, content, pos)
        {
            //..
        }

        public override void LoadContent()
        {
            _sprite = content.Load<Texture2D>("blue");
            //Update();
        }
    }

    /// <summary>
    /// Red square
    /// </summary>
    public class RedCharacter : PlayerCharacter
    {
        public RedCharacter(GameRenderManager renMan, ContentManager content, Point pos)
            : base(renMan, content, pos)
        {

        }

        public override void LoadContent()
        {
            _sprite = content.Load<Texture2D>("red");
            //Update();
        }
    }

    /// <summary>
    /// Green square
    /// </summary>
    public class GreenCharacter : PlayerCharacter
    {
        public GreenCharacter(GameRenderManager renMan, ContentManager content, Point pos)
            : base(renMan, content, pos)
        {

        }

        public override void LoadContent()
        {
            _sprite = content.Load<Texture2D>("green");
            //Update();
        }
    }
}
