using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameStateManagement
{
    public class GameClickableGuiElement : Renderable
    {
        protected ContentManager content;
        protected Texture2D guiElement;

        public GameClickableGuiElement(GameRenderManager renderMan, ContentManager content)
        {
            renderMan.AddRenderable(this);
            this.content = content;
        }

        /// <summary>
        /// Override this function to add Content loading logic.
        /// </summary>
        public void LoadContent()
        {

        }

        /// <summary>
        /// Override this function to add Update logic.
        /// </summary>
        /// <param name="deltaTime">time since last frame in total secounds</param>
        public void Update(float deltaTime)
        {

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
            get { return guiElement.Bounds; }
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
