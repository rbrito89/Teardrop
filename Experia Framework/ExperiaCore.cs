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

namespace Experia.Framework
{
    public class EngineCore: Game
    {
        new public ContentLoader Content = ContentLoader.Instance;
        protected EngineFlags m_EngineFlags;
        public EngineCore(EngineFlags flags)
        {

        }
    }
}
