using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeGame.Rendering
{
    /// <summary>
    /// A abstract class render logic.
    /// </summary>
    public interface Renderable
    {
        Texture2D sprite { get; set; } // Texture sprite
        Rectangle collisionBox { get; set; } // Collision rectangle
        Rectangle sourceBox { get; set; } // Source clip
    }
}
