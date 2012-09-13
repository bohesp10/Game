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
        protected  abstract Sprite objectSprite{ get; }
        protected Game game;
        protected Vector2 position;

        public GameObject(Game game, Point position)
        {
            this.game = game;
            RenderManager renderManager = 
                (RenderManager)game.Services.GetService(typeof(IRenderService));
            renderManager.AddRenderable(this);
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

    public class MyTestObject : GameObject
    {
        private StaticSprite testSprite;

        public MyTestObject(Game game, Point position)
            : base(game, position)
        {
            testSprite = new StaticSprite();
        }

        protected override Sprite objectSprite
        {
            get { return testSprite; }
        }

        public override void LoadContent()
        {
            testSprite.sprite = game.Content.Load<Texture2D>("green");
        }

        public override void Update(float deltaTime)
        {
            objectSprite.Update(position);
        }
    }
}
