using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeGame.Rendering
{
    /// <summary>
    /// Render Service
    /// </summary>
    public interface IRenderService
    {
        void AddRenderable(Renderable renderable); 
        void RemoveRenderable(Renderable renderable);
    }
}
