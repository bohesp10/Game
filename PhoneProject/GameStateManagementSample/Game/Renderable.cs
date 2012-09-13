using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameStateManagement
{
    public interface Renderable
    {
        Texture2D surface { get; }
        Rectangle collisionBox { get; }
        Rectangle sourceBox { get; }
        void LoadContent();
    }
}
