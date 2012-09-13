using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using AwesomeGame.Rendering;


namespace AwesomeGame.Rendering
{
    public class RenderManager : DrawableGameComponent, IRenderService
    {
        private List<Renderable> renderables = new List<Renderable>();
        private SpriteBatch spriteBatch;

        public RenderManager(Game game, SpriteBatch spriteBatch)
            : base(game)
        {    
            this.spriteBatch = spriteBatch;
            game.Components.Add(this);
            game.Services.AddService(typeof(IRenderService), this);
        }

        public void AddRenderable(Renderable renderable)
        {
            renderables.Add(renderable);
        }

        public void RemoveRenderable(Renderable renderable)
        {
            renderables.Add(renderable);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            for (int i = 0; i < renderables.Count; ++i)
            {
                spriteBatch.Draw(
                        renderables[i].sprite,
                        renderables[i].collisionBox,
                        renderables[i].sourceBox,
                        Color.White
                    );
            }
            spriteBatch.End();
        }
    }
}
