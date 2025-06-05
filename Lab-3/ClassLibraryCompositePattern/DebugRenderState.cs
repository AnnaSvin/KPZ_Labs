using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class DebugRenderState : IRenderState
    {
        public string Render(LightElementNode node)
        {
            var content = node.RenderWithIndentation();
            return $"<!-- {node.TagName} ({node.ChildCount} children) -->\n{content}";
        }
    }
}
