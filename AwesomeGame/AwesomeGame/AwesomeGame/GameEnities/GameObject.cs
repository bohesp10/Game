using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwesomeGame.Rendering;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeGame.GameEnities
{
    public abstract class GameObject : Renderable
    {
        protected Sprite objectSprite { get; set; }
        protected Game game;
        protected Vector2 position;

        public GameObject(Game game, Point position)
        {
            this.game = game;
            ((RenderManager)game.Services.GetService(
                typeof(IRenderService))).AddRenderable(this);
            this.position = new Vector2(position.X, position.Y);
        }

        public virtual Texture2D sprite
        {
            get { return objectSprite.sprite; }
            set {  }
        }

        public virtual Rectangle collisionBox
        {
            get { return objectSprite.collisionBox; }
            set { }
        }

        public virtual Rectangle sourceBox
        {
            get { return objectSprite.sourceBox; }
            set { }
        }


        public abstract void LoadContent();
        public abstract void Update(float deltaTime);
    }

    /// <summary>
    /// Example of how a gameobject can be created. 
    /// easy huh? :D
    /// </summary>
    public class MyTestObject : GameObject
    {
        public MyTestObject(Game game, Point position)
            : base(game, position)
        {
            objectSprite = new StaticSprite();
        }

        public override void LoadContent()
        {
            objectSprite.sprite = game.Content.Load<Texture2D>("green");
        }

        public override void Update(float deltaTime)
        {
            // Insert Update logic here. 
            // Input and movement.
            objectSprite.Update(position);
        }
    }
}
