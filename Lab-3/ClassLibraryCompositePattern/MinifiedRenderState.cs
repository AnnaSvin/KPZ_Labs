using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOwnHTML
{
    public class MinifiedRenderState : IRenderState
    {
        public string Render(LightElementNode node)
        {
            var sb = new StringBuilder();
            sb.Append($"<{node.TagName}");

            if (node.CssClasses.Count > 0)
                sb.Append($" class=\"{string.Join(" ", node.CssClasses)}\"");

            sb.Append(">");

            foreach (var child in node.Children)
                sb.Append(child.OuterHTML);

            sb.Append($"</{node.TagName}>");

            return sb.ToString();
        }
    }
}
