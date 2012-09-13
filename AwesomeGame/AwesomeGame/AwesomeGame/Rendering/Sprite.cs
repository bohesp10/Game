using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeGame.Rendering
{
    public abstract class Sprite : Renderable
    {
        private Texture2D _sprite;
        private Rectangle _collisionBox;
        private Rectangle _sourceBox;

        public Sprite()
        {
            
        }

        public virtual Texture2D sprite
        {
            get { return _sprite; }
            set { _sprite = value;}
        }

        public virtual Rectangle collisionBox
        {
            get { return _collisionBox; }
            set { _collisionBox = value; }
        }

        public virtual Rectangle sourceBox
        {
            get { return _sourceBox; }
            set { _sourceBox = value; }
        }

        public abstract void Update(Vector2 objectPos);
    }

    /// <summary>
    /// A static sprite that don't have animation.
    /// </summary>
    public class StaticSprite : Sprite
    {
        public StaticSprite()
            : base()
        {

        }

        public override void Update(Vector2 objectPos)
        {
            collisionBox = new Rectangle(
                (int)objectPos.X,
                (int)objectPos.Y,
                sprite.Width,
                sprite.Height
            );

            sourceBox = new Rectangle(
                0,
                0,
                sprite.Width,
                sprite.Height
            );
        }
    }

    /// <summary>
    /// A animated sprite.
    /// </summary>
    public class AnimationSprite : Sprite
    {
        public AnimationSprite()
            : base()
        {

        }

        public override void Update(Vector2 objectPos)
        {
            throw new NotImplementedException();
        }
    }
}
