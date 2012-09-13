using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameStateManagement
{
    public abstract class Character : Sprite
    {
        /// <summary>
        /// the sprite for this character. 
        /// </summary>
        //protected abstract Sprite characterSprite { get; }

        protected ContentManager content;

        /// <summary>
        /// Character Constructor
        /// </summary>
        /// <param name="renderMan">instance of render manager</param>
        /// <param name="game">instance of xna game class</param>
        public Character(Point position, GameRenderManager renderMan, ContentManager content)
            : base(position)
        {
            this.content = content;

            // when ever this object is created, add this object to render manager's list of renderables.
            renderMan.AddRenderable(this);

            
        }

        ///// <summary>
        ///// Override this function to add Content loading logic.
        ///// </summary>
        //public abstract void LoadContent();

        /// <summary>
        /// Override this function to add Update logic.
        /// </summary>
        /// <param name="deltaTime">time since last frame in total secounds</param>
        //public abstract void Update(float deltaTime);

        ///// <summary>
        ///// Returns the Texture2D object representing the sprite of this character.
        ///// Mainly used by Render Manager.
        ///// </summary>
        //public virtual Texture2D surface
        //{
        //    get { return characterSprite.surface; }
        //}

        ///// <summary>
        ///// Returns the Rectangle object representing the collision box
        ///// Mainly used by Render Manager.
        ///// </summary>
        //public virtual Rectangle collisionBox
        //{
        //    get { return characterSprite.collisionBox; }
        //}

        ///// <summary>
        ///// Returns the Rectangle object representing the source box
        ///// Mainly used by Render Manager.
        ///// </summary>
        //public virtual Rectangle sourceBox
        //{
        //    get { return characterSprite.sourceBox; }
        //}
    }
}
