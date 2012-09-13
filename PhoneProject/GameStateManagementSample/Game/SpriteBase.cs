using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameStateManagement
{
    /// <summary>
    /// Base class for all Sprites that should be drawn to screen
    /// </summary>
    public abstract class Sprite : Renderable
    {
        // Constants of current sprite sheet width and heights. 
        // This probably would have been taken from a data/xml 
        // file in a real case scenario to make this class even more abstract.  
        protected const int SPRITE_WIDTH = 24;
        protected const int SPRITE_HEIGHT = 32;

        /// <summary>
        /// The Texture2D that the spritebatch need to draw images on screen.
        /// </summary>
        public Texture2D _sprite { get; set; }

        /// <summary>
        /// The Rectangle object representing the collisionbox of this sprite
        /// needed by the sprite batch object. 
        /// </summary>
        protected Rectangle _collisionBox { get; set; }


        /// <summary>
        /// The Rectangle object representing the sourceBox of this sprite sheet
        /// mainly used when you got a sprite sheet and "clip" it into the piece you want to show up
        /// on screen. 
        /// </summary>
        protected Rectangle _sourceBox { get; set; }

        /// <summary>
        ///  The position variable of this sprite
        /// </summary>
        public Vector2 position;

        /// <summary>
        /// Sprite Constructor 
        /// </summary>
        /// <param name="position">Position for sprite</param>
        public Sprite(Point position)
        {
            this.position = new Vector2(position.X, position.Y);
           //_collisionBox = new Rectangle(position.X, position.Y, _sprite.Bounds.Width)
           // _collisionBox.X = position.X;
           // _collisionBox.Y = position.Y;
        }

        /// <summary>
        /// Returns the Texture2D object
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Texture2D surface
        {
            get { return _sprite; }
        }

        /// <summary>
        /// Returns the Rectangle object representing the collision box
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Rectangle collisionBox
        {
            get { return _collisionBox; }
        }

        /// <summary>
        /// Returns the Rectangle object representing the source box
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Rectangle sourceBox
        {
            get { return _sourceBox; }
        }

        public virtual void Update(float deltaTime)
        {
            //position.Y -= deltaTime * MOVEMENT_SPEED;
        }
        public abstract void LoadContent();
    }

    ///// <summary>
    ///// Sprite class for static sprites.
    ///// </summary>
    //public class StaticSprite : Sprite
    //{
    //    public StaticSprite(Point position)
    //        : base(position)
    //    {

    //    }

    //    public override void Update()
    //    {
    //        _collisionBox = new Rectangle(
    //            (int)position.X,
    //            (int)position.Y,
    //            surface.Width,
    //            surface.Height
    //        );

    //        _sourceBox = new Rectangle(
    //            0,
    //            0,
    //            surface.Width,
    //            surface.Height
    //        );
    //    }

    //    public override virtual void LoadContent()
    //    {

    //    }
    //}
}
