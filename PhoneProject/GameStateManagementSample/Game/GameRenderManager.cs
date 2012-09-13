using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameStateManagement
{
    public class GameRenderManager
    {
       /// <summary>
        /// A instance of the SpriteBatch object.
        /// </summary>
        private SpriteBatch spriteBatch;

        /// <summary>
        /// List of all renderables that shall be rendered.
        /// </summary>
        private List<Renderable> renderables = new List<Renderable>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spriteBatch">instance of SpriteBatch object</param>
        public GameRenderManager(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        public void Render()
        {
            foreach (Renderable surface in renderables)
            {
                spriteBatch.Draw(surface.surface,
                surface.collisionBox,
                surface.sourceBox,
                Color.White);
            }
        }

        /// <summary>
        /// Adds renderables to list. 
        /// </summary>
        /// <param name="renderable">The renderable that shall be added</param>
        public void AddRenderable(Renderable renderable)
        {
            renderable.LoadContent();
            renderables.Add(renderable);
        }

        /// <summary>
        /// Remove renderable from list.
        /// </summary>
        /// <param name="renderable">The renderable that shall 
        /// be removed</param>
        public void RemoveRenderable(Renderable renderable)
        {
            renderables.Remove(renderable);
        }
    }
}
