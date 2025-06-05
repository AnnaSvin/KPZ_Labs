using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class NormalRenderState : IRenderState
    {
        public string Render(LightElementNode node)
        {
            return node.RenderWithIndentation();
        }
    }
}
