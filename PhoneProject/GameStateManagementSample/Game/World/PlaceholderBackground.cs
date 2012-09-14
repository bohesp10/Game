using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameStateManagement
{
    class PlaceholderBackground : Renderable
    {
        protected ContentManager content;
        protected Texture2D guiElement;

        public PlaceholderBackground(GameRenderManager renderMan, ContentManager content)
        {
            this.content = content;
            renderMan.AddRenderable(this);
        }

        /// <summary>
        /// Override this function to add Content loading logic.
        /// </summary>
        public void LoadContent()
        {
            guiElement = content.Load<Texture2D>("game menu");
        }


        /// <summary>
        /// Returns the Texture2D object representing the sprite of this character.
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Texture2D surface
        {
            get { return guiElement; }
        }

        /// <summary>
        /// Returns the Rectangle object representing the collision box
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Rectangle collisionBox
        {
            //Change to get the size of screen rather then constant values
            get { return new Rectangle(0, 0, 800, 480); }
        }

        /// <summary>
        /// Returns the Rectangle object representing the source box
        /// Mainly used by Render Manager.
        /// </summary>
        public virtual Rectangle sourceBox
        {
            get { return guiElement.Bounds; }
        }
    }
}
